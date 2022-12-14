import { makeAutoObservable, runInAction } from "mobx";
import agent from "../api/agent";
import { Profile } from "../models/profile";
import { store } from "./store";

export default class ProfileStore {
    profile : Profile | null = null;
    loadingProfile = false;
    uploading = false;

    constructor(){
        makeAutoObservable(this);
    }

    get isCurrentUser(){
        if(store.userStore.user && this.profile){
            return store.userStore.user.username === this.profile.username;
        }

        return false;
    }

    loadProfile = async (username: string) => {
        this.loadingProfile = true;
        try{
            const profile = await agent.Profiles.get(username);
            runInAction(() => {
                debugger
                this.profile = profile;
                this.loadingProfile = false;
            })

        }catch(error){
            console.log(error);
            runInAction(() => {
                this.loadingProfile = false;
            })
        }
    }

    uploadPhoto = async (file:Blob) => {
        try{
            this.uploading = false;
            const response = await agent.Profiles.uploadPhoto(file);
            const photo = response.data;
            runInAction(() => {
                if(this.profile){
                    this.profile.photos?.push(photo);
                    if(photo.isMain && store.userStore.user){
                        store.userStore.setImage()
                    }
                }
                this.uploading = false;
            })
        }catch(error){
            console.log(error);
            runInAction(() => {
                this.uploading = false;
            })            
        }
    }
}