import { makeAutoObservable, runInAction } from "mobx";
import { Profile } from "../models/profile";

export default class ProfileStore {
    profile : Profile | null = null;
    loadingProfile = false;

    constructor(){
        makeAutoObservable(this);
    }

    loadProfile = async (username: string) => {
        this.loadingProfile = true;
        try{

        }catch(error){
            console.log(error);
            runInAction()
        }
    }
}