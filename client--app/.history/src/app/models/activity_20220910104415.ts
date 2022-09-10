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

    export class ActivityFormValues {
        
    }