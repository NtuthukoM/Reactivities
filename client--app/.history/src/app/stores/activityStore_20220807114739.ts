import { makeObservable, observable } from "mobx";
import { autoAction } from "mobx/dist/internal";

export default class ActivityStore {
    title = 'Hello from mobx';

    constructor() {
        makeObservable(this, {
            title: observable,
            setTitle: autoAction
        });
    }

    setTitle = () =>{
        this.title += '!';
    }
}