import { action, makeAutoObservable, makeObservable, observable, runInAction } from "mobx";
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

    loadActivities = async () => {
        try{
          const activities:Activity[] =  await agent.Activities.list();
          activities.forEach(x =>
            {
               this.setActivity(x);
            });
        }catch(error){
            console.log(error);
        }
        this.setLoadingInitial(false);
    }

    loadActivity = async (id: number) => {
        let activity: Activity | undefined = this.getActivity(id);
        if(activity){
            this.selectedActivity = activity;
        }
        else {
            this.loadingInitial = true;
            try{
            activity = await agent.Activities.details(id);
            this.setActivity(activity);
            //this.setLoadingInitial(false);
            this.loadingInitial = false;
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
        try{
            await agent.Activities.create(activity);
            let maxId: number = 0;
            this.activityRegistry.forEach(x => {
                    if(x.id > maxId){
                        maxId = x.id;
                    }
            });
            maxId = maxId + 1;    
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