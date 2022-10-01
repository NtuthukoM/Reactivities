import { HubConnection } from "@microsoft/signalr";
import { makeAutoObservable } from "mobx";
import { ChatComment } from "../models/comment";
import { store } from "./store";

export default class CommentStore {
    comments: ChatComment[]= [];
    hubConnection: HubConnection | null = null;

    constructor(){
        makeAutoObservable(this);
    }

    creatHubbConnection = (activityId: number) => {
        if(store.activityStore.selectedActivity){
            this.hubConnection = new HubConnectionBuilder()
            .withUrl("http://localhost:5000/chat?activityId="+activityId, {

            });

            //Start the connection:
            this.hubConnection?.start()
            .catch(error => console.log("Error connecting to hub: "+ error));

            this.hubConnection?.on("LoadComments", () => {});
        }
    }
}