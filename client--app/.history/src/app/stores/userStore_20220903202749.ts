import { makeAutoObservable } from "mobx";
import agent from "../api/agent";
import { User, UserFormValues } from "../models/user";

export default class UserStore {
    user: User | null = null;

    constructor(){
        makeAutoObservable(this);
    }

    get isLoggedIn () {
        return !!this.user;
    }

    logIn = async (creds: UserFormValues) => {
        try{
           const user = await agent.Account.login(creds);
        }catch(error){
            throw error;
        }
    }
}