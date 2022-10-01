import { HubConnection } from "@microsoft/signalr";
import { ChatComment } from "../models/comment";

export default class CommentStore {
    comments: ChatComment[]= [];
    hubConnection: HubConnection
}