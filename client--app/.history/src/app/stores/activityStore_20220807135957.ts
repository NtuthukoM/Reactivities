import { action, makeAutoObservable, makeObservable, observable } from "mobx";

export default class ActivityStore {
    activities

    constructor() {
        makeAutoObservable(this);
    }
}