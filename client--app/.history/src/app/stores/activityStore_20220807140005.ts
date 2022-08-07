import { action, makeAutoObservable, makeObservable, observable } from "mobx";

export default class ActivityStore {
    activities: Activity[] = [];
    

    constructor() {
        makeAutoObservable(this);
    }
}