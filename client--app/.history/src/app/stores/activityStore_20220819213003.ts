import { makeAutoObservable, runInAction } from "mobx";
import agent from "../api/agent";
import { Activity } from "../models/activity";

export default class ActivityStore {
    activityRegistry = new Map<number, Activity>();
    selectedActivity: Activity | undefined = undefined;
    editMode: boolean = false;
    loading : boolean = false;
    loadingInitial: boolean = true;

    constructor() {
        makeAutoObservable(this);
    }

    get activitiesByDate () {
        return Array.from(this.activityRegistry.values())
        .sort((a, b) => Date.parse(a.date) - Date.parse(b.date));
    }

    get getGroupedActivities() {
        return Object.entries(
          this.activitiesByDate.reduce((activities, activity) => {
            const date = activity.date;
            activities[date] = activities[date] ? [...activities[date], activity] : [act]

          })
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
        activity.date = activity.date.split('T')[0];
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

}