import { format } from "date-fns";
import { makeAutoObservable, runInAction } from "mobx";
import agent from "../api/agent";
import { Activity } from "../models/activity";
import { store } from "./store";

export default class ActivityStore {
    activityRegistry = new Map<number, Activity>();
    selectedActivity: Activity | undefined = undefined;
    editMode: boolean = false;
    loading : boolean = false;
    loadingInitial: boolean = false;

    constructor() {
        makeAutoObservable(this);
    }

    get activitiesByDate () {
        return Array.from(this.activityRegistry.values())
        .sort((a, b) => a.date!.getTime() - b.date!.getTime());
    }

    get getGroupedActivities() {
        return Object.entries(
          this.activitiesByDate.reduce((activities, activity) => {
            const date = format(activity.date!,'dd MMM yyyy');
            activities[date] = activities[date] ? [...activities[date], activity] : [activity];
            return activities;
          }, {} as {[key:string]: Activity[] })
        );
    }

    loadActivities = async () => {
        this.loadingInitial = true;
        try{
          const activities:Activity[] =  await agent.Activities.list();
          activities.forEach(x =>
            {
               this.setActivity(x);
            });
            this.setLoadingInitial(false);
        }catch(error){
            console.log(error);
        }
        this.setLoadingInitial(false);
    }

    loadActivity = async (id: number) => {
        let activity: Activity | undefined = this.getActivity(id);
        if(activity){
            this.selectedActivity = activity;   
            return activity;         
        }
        else {
            this.loadingInitial = true;
            try{
            activity = await agent.Activities.details(id);
            this.setActivity(activity);
            this.setSelectedActivity(activity.id);
            this.setLoadingInitial(false);
            return activity;
            }catch(error){
                console.log(error);
                this.setLoadingInitial(false);
            }
        }
    }

    private getActivity = (id: number) => {
        return this.activityRegistry.get(id);
    }

    private setActivity = (activity: Activity) => {
        const user = store.userStore.user;
        if(user){
            activity.isGoing = activity.attendees!.some(x =>
                x.username == user.username);
            activity.isHost = activity.hostUsername == user.username;
            activity.host = activity.attendees!.find(x => x.username == activity.hostUsername);
        }
        activity.date = new Date(activity.date!);
        this.activityRegistry.set(activity.id, activity);
    }

    setLoadingInitial = (state: boolean) => {
        this.loadingInitial = state;
    }

    setSelectedActivity = (id: number) => {
        this.selectedActivity = this.activityRegistry.get(id);
        console.log(this.selectedActivity);
        this.editMode = false;
    }

    createActivity = async (activity: Activity) => {
        this.loading = true;
        let maxId: number = 0;
        this.activityRegistry.forEach(x => {
                if(x.id > maxId){
                    maxId = x.id;
                }
        });
        maxId = maxId + 1;          
        try{
            await agent.Activities.create(activity);  
            runInAction(() => {
                activity.id = maxId;
                this.activityRegistry.set(activity.id, activity);
                this.loading = false;
                this.editMode = false;
                this.selectedActivity = activity;
            })        
        }catch(error){
            console.log(error);
            runInAction(() => {
                this.loading = false;
            })
        }
        return maxId;
    }

    updateActivity =async (activity:Activity) => {
        this.loading = true;
        try{
            await agent.Activities.update(activity);
            runInAction(() => {
                this.activityRegistry.set(activity.id, activity);
                this.selectedActivity = activity;
                this.editMode = false;
                this.loading = false;
            })
        }catch(error)
        {
            console.log(error);
            runInAction(() => {
                this.loading = false;
            })
        }
    }

    deleteActivity = async (id: number) => {
        this.loading = true;
        try{
            await agent.Activities.delete(id);
            runInAction(() => {
                this.activityRegistry.delete(id);
                this.loading = false;
            });
        }catch(error){
            runInAction(() => {
                this.loading = false;
            });
        }
    }

    updateAttendance =async () => {
        const user = store.userStore.user;
        this.loading = true;
        try{
            await agent.Activities.attend(this.selectedActivity!.id);
            runInAction(() => (


            ))
        }catch(error){
            console.log(error);
        }finally{
            runInAction(() => {
                this.loading = false;
            })
        }
    }

}