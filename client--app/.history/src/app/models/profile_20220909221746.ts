export interface Profile {
    username:string;
    displayName: string;
    image?:string;
    bio?:string
}

export class ProfileImpl extends Profile {

}