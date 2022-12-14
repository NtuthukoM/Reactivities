import { makeAutoObservable, runInAction } from "mobx";
import agent from "../api/agent";
import { User, UserFormValues } from "../models/user";
import { store } from "./store";

export default class UserStore {
    user: User | null = null;

    constructor(){
        makeAutoObservable(this);
    }

    get isLoggedIn () {
        return !!this.user;
    }

    login = async (creds: UserFormValues) => {
        try{
           const user = await agent.Account.login(creds);
           store.commonStore.setToken(user.token);
           runInAction
           console.log(user);
        }catch(error){
            throw error;
        }
    }
}