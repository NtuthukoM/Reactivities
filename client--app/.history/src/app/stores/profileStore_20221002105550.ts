import { makeAutoObservable, reaction, runInAction } from "mobx";
import agent from "../api/agent";
import { Photo, Profile } from "../models/profile";
import { store } from "./store";

export default class ProfileStore {
    profile : Profile | null = null;
    loadingProfile = false;
    uploading = false;
    loading = false;
    loadingFollowings = false;
    followings: Profile[] = [];
    activeTab = 0;

    constructor(){
        makeAutoObservable(this);

        reaction(() => 
            this.activeTab, tab => {
                if(tab === 3 || tab === 4) {
                    const predicate = tab === 3 ? 'following' : 'followers';
                    load
                }
            }
        )
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
            this.uploading = true;
            const response = await agent.Profiles.uploadPhoto(file);
            const photo = response.data;
            runInAction(() => {
                if(this.profile){
                    this.profile.photos?.push(photo);
                    if(photo.isMain && store.userStore.user){
                        store.userStore.setImage(photo.url);
                        this.profile.image = photo.url;
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

    setMainPhoto= async (photo:Photo) => {
        this.loading = true;
        try{
            await agent.Profiles.setMainPhoto(photo.id);
            store.userStore.setImage(photo.url);
            runInAction(() => {
                if(this.profile && this.profile.photos){
                    this.profile.photos.find(p => p.isMain)!.isMain = false;
                    this.profile.photos.find(p => p.id === photo.id)!.isMain = true;
                    this.profile.image = photo.url;
                }
                this.loading = false;
            })
        }catch(error){
            runInAction(() =>{
                this.loading = false;
                console.log(error);
            })
        }
    }

    deletePhoto = async (id:string) => {
        this.loading = true;
        try{
            await agent.Profiles.deletePhoto(id);
            runInAction(() => {
                debugger;
                    if(this.profile){
                        this.profile.photos = 
                        this.profile.photos?.filter(x => x.id !== id);
                    }
                    this.loading = false;
            })

        }catch(error){
            runInAction(() => this.loading = false);
        }
    }

    updateFollowing = async (username: string, following: boolean) => {
        this.loading= true;
        try{
            await agent.Profiles.updateFollowing(username);
            store.activityStore.updateAttendeeFollowing(username);
            runInAction(() =>{
                if(this.profile && this.profile.username !== username){
                    following ? this.profile.followersCount++ :
                        this.profile.followingCount--;
                    this.profile.following = !this.profile.following;
                }
                this.followings.forEach(profile => {
                    if(profile.username === username){
                        profile.following ? profile.followersCount-- : profile.followingCount++;
                        profile.following = !profile.following;
                    }
                });
                this.loading = false;
            })
        }catch(error){
            console.log(error);
            runInAction(() => this.loading = false);
        }
    }

    loadFollowings = async (predicate: string) => {
        this.loadingFollowings = true;
        try{
            const followings = await agent.Profiles.listFollowings(this.profile?.username!, predicate);

            runInAction(() => {
                this.followings = followings;
                this.loadingFollowings = false;
            })
        }catch(error){
            console.log(error);
            runInAction(() => this.loadingFollowings = false);
        }
    }
}