import { action, makeAutoObservable, makeObservable, observable, runInAction } from "mobx";
import agent from "../api/agent";
import { Activity } from "../models/activity";

export default class ActivityStore {
    activities: Activity[] = [];
    activityRegistry = new Map<number, Activity>();
    selectedActivity: Activity | undefined = undefined;
    editMode: boolean = false;
    loading : boolean = false;
    loadingInitial: boolean = false;

    constructor() {
        makeAutoObservable(this);
    }

    get activities

    loadActivities = async () => {
        this.setLoadingInitial(true);
        try{
          const activities:Activity[] =  await agent.Activities.list();
          activities.forEach(x =>
            {
                x.date = x.date.split('T')[0];
                this.activityRegistry.set(x.id, x);
            });
        }catch(error){
            console.log(error);
        }
        this.setLoadingInitial(false);
    }

    setLoadingInitial = (state: boolean) => {
        this.loadingInitial = state;
    }

    setSelectedActivity = (id: number) => {
        this.selectedActivity = this.activityRegistry.get(id);
        console.log(this.selectedActivity);
        this.editMode = false;
    }

    cancelSelectedActivity = () => {
        this.selectedActivity = undefined;
    }

    openForm = (id?:number) => {
        id ? this.setSelectedActivity(id) : this.cancelSelectedActivity();
        this.editMode = true;
    }

    closeForm = () => {
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
                if(this.selectedActivity?.id === id)
                    this.cancelSelectedActivity();
            });
        }catch(error){
            runInAction(() => {
                this.loading = false;
            });
        }
    }

}