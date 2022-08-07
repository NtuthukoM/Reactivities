import { action, makeAutoObservable, makeObservable, observable, runInAction } from "mobx";
import agent from "../api/agent";
import { Activity } from "../models/activity";

export default class ActivityStore {
    activities: Activity[] = [];
    selectedActivity: Activity | undefined = undefined;
    editMode: boolean = false;
    loading : boolean = false;
    loadingInitial: boolean = false;

    constructor() {
        makeAutoObservable(this);
    }

    loadActivities = async () => {
        this.setLoadingInitial(true);
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
        this.setLoadingInitial(false);
    }

    setLoadingInitial = (state: boolean) => {
        this.loadingInitial = state;
    }

    setSelectedActivity = (id: number) => {
        this.selectedActivity = this.activities.find(x => x.id === id);
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
            for(let i = 0; i < this.activities.length; i++){
              if(this.activities[i].id > maxId){
                maxId = this.activities[i].id;
              }
            }
            maxId = maxId + 1;    
            runInAction()        
        }catch(error){

        }
    }

}