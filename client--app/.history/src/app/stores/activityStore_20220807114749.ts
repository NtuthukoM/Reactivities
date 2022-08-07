import { makeObservable, observable } from "mobx";
import { action, autoAction } from "mobx/dist/internal";

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