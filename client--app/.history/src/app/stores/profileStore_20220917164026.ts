import { makeAutoObservable } from "mobx";
import { Profile } from "../models/profile";

export default class ProfileStore {
    profile : Profile | null = null;
    loadingProfile = false;

    constructor(){
        makeAutoObservable(this)
    }
}