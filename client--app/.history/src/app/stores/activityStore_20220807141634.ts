import { action, makeAutoObservable, makeObservable, observable, runInAction } from "mobx";
import agent from "../api/agent";
import { Activity } from "../models/activity";

export default class ActivityStore {
    activities: Activity[] = [];
    selectedActivity: Activity | null = null;
    editMode: boolean = false;
    loading : boolean = false;
    loadingInitial: boolean = false;

    constructor() {
        makeAutoObservable(this);
    }

    loadActivities = async () => {
        this.loadingInitial = true;
        try{
          const activities:Activity[] =  await agent.Activities.list();
          activities.forEach(x =>
            {
                x.date = x.date.split('T')[0];
                this.activities.push(x);
            });
        }catch(error){
            console.log(error);
        }
        runInAction(() => {
            this.loadingInitial = false;
        })
    }

    setLoadingInitial = (state: boolean) => {
        this.loadingInitial = state;
    }
}