import { action, makeAutoObservable, makeObservable, observable } from "mobx";
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
          const   await agent.Activities.list()
            .then(response => {
              let activities : Activity[] = [];
              response.forEach(x =>
                {
                    x.date = x.date.split('T')[0];
                    activities.push(x);
                });
              setActivities(activities);
              setLoading(false);
        }catch(error){
            console.log(error);
        }
    }
}