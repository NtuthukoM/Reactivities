export interface Profile {
    username:string;
    displayName: string;
    image?:string;
    bio?:string
}

export class Profile extends Profile {

}