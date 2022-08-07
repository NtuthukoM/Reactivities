import { makeObservable, observable } from "mobx";
import { action,toAction } from "mobx/dist/internal";

export default class ActivityStore {
    title = 'Hello from mobx';

    constructor() {
        makeObservable(this, {
            title: observable,
            setTitle: action
        });
    }

    setTitle = () =>{
        this.title += '!';
    }
}