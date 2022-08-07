import { action, makeAutoObservable, makeObservable, observable } from "mobx";

export default class ActivityStore {
    title = 'Hello from mobx';

    constructor() {
        makeAutoObservable(thi)
        makeObservable(this, {
            title: observable,
            setTitle: action
        });
    }

    setTitle = () =>{
        this.title = this.title + '!';
    };
}