export interface Profile {
    username:string;
    displayName: string;
    image?:string;
    bio?:string
}

export default class Profile extends Profile 