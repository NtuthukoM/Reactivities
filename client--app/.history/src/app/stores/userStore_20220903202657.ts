import { makeAutoObservable } from "mobx";
import agent from "../api/agent";
import { User } from "../models/user";

export default class UserStore {
    user: User | null = null;

    constructor(){
        makeAutoObservable(this);
    }

    get isLoggedIn () {
        return !!this.user;
    }

    logIn = async () => {
        try{
            await agent.Account.login()
        }catch(error){
            throw error;
        }
    }
}