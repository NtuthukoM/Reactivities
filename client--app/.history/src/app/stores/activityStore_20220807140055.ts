import { action, makeAutoObservable, makeObservable, observable } from "mobx";
import { Activity } from "../models/activity";

export default class ActivityStore {
    activities: Activity[] = [];
    selectedActivity: Activity | null = null;
    editMode: boolean = false;
    isLoading 

    constructor() {
        makeAutoObservable(this);
    }
}