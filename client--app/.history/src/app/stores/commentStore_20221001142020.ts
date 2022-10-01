import { HubConnection } from "@microsoft/signalr";
import { makeAutoObservable, runInAction } from "mobx";
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

            //Wire the events/methods:
            this.hubConnection?.on("LoadComments", (comments: ChatComment[]) => {
                runInAction(() => {
                    this.comments = comments;
                })
            });
            this.hubConnection?.on("ReceiveComment", (comment: ChatComment) => {
                runInAction(() => {
                    this.comments.push(comment);
                });
                    
            });
        }
    }

    stopHubConnection = () => {
        this.hubConnection?.stop()
        .catch(error => console.log("Error stopping connection: "))
    }
}