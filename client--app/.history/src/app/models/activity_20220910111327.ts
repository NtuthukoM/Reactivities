import { object } from "yup";
import { Profile } from "./profile";

    export interface Activity {
        id: number;
        title: string;
        date: Date | null;
        description: string;
        category: string;
        city: string;
        venue: string;
        hostUsername:string;
        isCancelled:boolean;
        attendees: Profile[];
        isGoing: boolean;
        isHost: boolean;
        host?: Profile;
    }

    export class Activity implements Activity{
        constructor(init?: ActivityFormValues){
            Object.assign(this, init);
        }
    }

    export class ActivityFormValues {
        id?: number = undefined;
        title: string = '';
        date?: Date = undefined;
        description: string = '';
        category: string = '';
        city: string = '';
        venue: string = ''

        constructor(activity?: ActivityFormValues){
            if(activity) {
                this.id = activity.id;
                this.title = activity.title;
                this.date = activity.date;
                this.description = activity.description;
                this.category = activity.category;
                this.city = activity.city;
                this.venue = activity.venue;
            }
        }

        constructor(activity?: Activity){
            if(activity) {
                this.id = activity.id;
                this.title = activity.title;
                this.date = activity.date;
                this.description = activity.description;
                this.category = activity.category;
                this.city = activity.city;
                this.venue = activity.venue;
            }
        }        
    }