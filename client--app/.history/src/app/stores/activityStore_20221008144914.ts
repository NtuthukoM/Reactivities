import { format } from "date-fns";
import { url } from "inspector";
import { makeAutoObservable, reaction, runInAction } from "mobx";
import { runInThisContext } from "vm";
import agent from "../api/agent";
import { Activity, ActivityFormValues } from "../models/activity";
import { Pagination, PagingParams } from "../models/pagination";
import { Profile } from "../models/profile";
import { store } from "./store";

export default class ActivityStore {
    activityRegistry = new Map<number, Activity>();
    selectedActivity: Activity | undefined = undefined;
    editMode: boolean = false;
    loading : boolean = false;
    loadingInitial: boolean = false;
    pagination: Pagination | null = null;
    pagingParams = new PagingParams();
    predicate = new Map().set('all', true);

    constructor() {
        makeAutoObservable(this);
        reaction()
    }

    setPredicate = (predicate: string, value: string | Date) => {
        const resetPredicate = () => {
            this.predicate.forEach((value, key) => {
                if(key !== 'startDate')
                this.predicate.delete(key);
            });
        }
        switch(predicate){
            case 'all':
                resetPredicate();
                this.predicate.set(predicate, true);
            break;
            case 'isGoing':
                resetPredicate();
                this.predicate.set(predicate, true);
            break;
            case 'isHost':
                resetPredicate();
                this.predicate.set(predicate, true);
            break;

            case 'startDate':
                this.predicate.delete(predicate);
                this.predicate.set(predicate, value);

            break;
        }
        
        this.predicate.set(predicate, value);
    }

    setPagingParams = (pagingParams: PagingParams) => {
        this.pagingParams = pagingParams;
    }

    get axiosParams () {
        const params = new URLSearchParams();
        params.append('pageNumber', this.pagingParams.pageNumber.toString());
        params.append('pageSize', this.pagingParams.pageSize.toString());
        this.predicate.forEach((value, key) => {
            if(key === 'startDate'){
                params.append(key, (value as Date).toISOString());
            } else {
                params.append(key, value);
            }
        });
        return params;
    }

    get activitiesByDate () {
        return Array.from(this.activityRegistry.values())
        .sort((a, b) => a.date!.getTime() - b.date!.getTime());
    }

    get getGroupedActivities() {
        return Object.entries(
          this.activitiesByDate.reduce((activities, activity) => {
            const date = format(activity.date!,'dd MMM yyyy');
            activities[date] = activities[date] ? [...activities[date], activity] : [activity];
            return activities;
          }, {} as {[key:string]: Activity[] })
        );
    }

    loadActivities = async () => {
        this.loadingInitial = true;
        try{
          const result =  await agent.Activities.list(this.axiosParams);
          result.data.forEach(x =>
            {
               this.setActivity(x);
            });
            this.setPagination(result.pagination);
            this.setLoadingInitial(false);
        }catch(error){
            console.log(error);
        }
        this.setLoadingInitial(false);
    }

    setPagination = (pagination: Pagination) => {
        this.pagination = pagination;
    }

    loadActivity = async (id: number) => {
        let activity: Activity | undefined = this.getActivity(id);
        if(activity){
            this.selectedActivity = activity;   
            return activity;         
        }
        else {
            this.loadingInitial = true;
            try{
            activity = await agent.Activities.details(id);
            this.setActivity(activity);
            this.setSelectedActivity(activity.id);
            this.setLoadingInitial(false);
            return activity;
            }catch(error){
                console.log(error);
                this.setLoadingInitial(false);
            }
        }
    }

    private getActivity = (id: number) => {
        return this.activityRegistry.get(id);
    }

    private setActivity = (activity: Activity) => {
        const user = store.userStore.user;
        if(user){
            activity.isGoing = activity.attendees!.some(x =>
                x.username === user.username);
            activity.isHost = activity.hostUsername === user.username;
            activity.host = activity.attendees!.find(x => x.username === activity.hostUsername);
        }
        activity.date = new Date(activity.date!);
        this.activityRegistry.set(activity.id, activity);
    }

    setLoadingInitial = (state: boolean) => {
        this.loadingInitial = state;
    }

    setSelectedActivity = (id: number) => {
        this.selectedActivity = this.activityRegistry.get(id);
        console.log(this.selectedActivity);
        this.editMode = false;
    }

    createActivity = async (activity: ActivityFormValues) => {
        const user = store.userStore.user;
        const attendee = new Profile(user!);
        let maxId: number = 0;
        this.activityRegistry.forEach(x => {
                if(x.id > maxId){
                    maxId = x.id;
                }
        });
        maxId = maxId + 1;       

        try{
            await agent.Activities.create(activity);  
            runInAction(() => {
                activity.id = maxId;
                const model = new Activity(activity);
                model.hostUsername = user!.username;
                model.attendees = [attendee];
                this.setActivity(model);
                this.activityRegistry.set(activity.id, model);
                this.selectedActivity = model;
            })        
        }catch(error){
            console.log(error);
        }
        return maxId;
    }

    updateActivity =async (activity:ActivityFormValues) => {
        try{
            await agent.Activities.update(activity);
            
            runInAction(() => {
                if(activity.id){
                    const model = {...this.getActivity(activity.id), ...activity};
    
                    this.activityRegistry.set(activity.id, model as Activity);
                    this.selectedActivity = model as Activity;
                }
            })
        }catch(error)
        {
            console.log(error);
        }
    }

    deleteActivity = async (id: number) => {
        this.loading = true;
        try{
            await agent.Activities.delete(id);
            runInAction(() => {
                this.activityRegistry.delete(id);
                this.loading = false;
            });
        }catch(error){
            runInAction(() => {
                this.loading = false;
            });
        }
    }

    updateAttendance =async () => {
        const user = store.userStore.user;
        this.loading = true;
        try{
            await agent.Activities.attend(this.selectedActivity!.id);
            runInAction(() => {
                if(this.selectedActivity?.isGoing){
                    debugger;
                    this.selectedActivity.attendees = this.selectedActivity.attendees?.filter(x => (x.username !== user?.username));
                    this.selectedActivity.isGoing = false;
                } else {
                    const attendee = new Profile(user!);
                    this.selectedActivity?.attendees?.push(attendee);
                    this.selectedActivity!.isGoing = true;
                }
                this.activityRegistry.set(this.selectedActivity!.id, this.selectedActivity!);
            })
        }catch(error){
            console.log(error);
        }finally{
            runInAction(() => {
                this.loading = false;
            })
        }
    }

    cancelActivityToggle = async () => {
        this.loading = true;
        try{
            await agent.Activities.attend(this.selectedActivity!.id);
            this.selectedActivity!.isCancelled = !(this.selectedActivity!.isCancelled);
            this.activityRegistry.set(this.selectedActivity!.id, this.selectedActivity!);
        }catch(error){
            console.log(error);
        }
        finally{
            runInAction(() => 
                this.loading = false
            )
        }
    }

    clearSelectedActivity = () => {
        this.selectedActivity = undefined;
    }

    updateAttendeeFollowing = (username: string) => {
        this.activityRegistry.forEach(activity => {
            activity.attendees.forEach(attendee => {
                if(attendee.username === username){
                    attendee.following ? attendee.followersCount--
                    : attendee.followingCount++;
                    attendee.following = !attendee.following;
                }
            })
        })
    }

}