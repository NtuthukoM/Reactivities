import axios, { AxiosError, AxiosResponse } from "axios";
import { toast } from "react-toastify";
import { Activity, ActivityFormValues } from "../models/activity";
import { store } from "../stores/store";
import {history} from "../../index";
import { User, UserFormValues } from "../models/user";
import { Photo, Profile } from "../models/profile";
import { PaginatedResult } from "../models/pagination";

axios.defaults.baseURL = "http://localhost:5118/api";
const responseBody = <T>(response : AxiosResponse<T>) => response.data;

const sleep = (delay: number) =>{
    return new Promise((resolve) => {
        setTimeout(resolve, delay);

    })
};

axios.interceptors.request.use(config => {
    const token = store.commonStore.token;
    if(token){
        config.headers!.Authorization = `Bearer ${token}`;
    }
    return config;
})

axios.interceptors.response.use(async response => {
        await sleep(1000);
        const pagination = response.headers['pagination'];
        if(pagination){
            response.data = new PaginatedResult(response.data, JSON.parse(pagination));
            const dataResponse = response.data;

        }
        else{
            return response;
        }
},(error: AxiosError) =>{
    const {data, status} = error.response!;
    const _data:any = data;
    switch(status){
        case 400:
            toast.error("Bad request");
            if(_data.errors){
                const modelStateErrors = [];
                for(const key in _data.errors){
                    if(_data.errors[key]){
                        modelStateErrors.push(_data.errors[key]);
                    }
                }

                throw modelStateErrors.flat();
            }else{

                toast.error("Bad request");
            }
            break;
            case 401:
                toast.error("unauthorised");
                break;
                case 404:
                    history.push('/not-found');
                    break;
                    case 500:                        
                        store.commonStore.setServerError(_data);
                        history.push('/server-error');

    }
    return Promise.reject(error);
});
const requests = {
    get : <T>(url: string) => axios.get<T>(url).then(responseBody),
    post : <T>(url: string, body: {}) => axios.post<T>(url, body).then(responseBody),
    put : <T>(url: string, body: {}) => axios.put<T>(url, body).then(responseBody),
    del : <T>(url: string) => axios.delete<T>(url).then(responseBody),

};

const Activities = {
    list: (params: URLSearchParams) => axios.get<PaginatedResult<Activity[]>>('/activities', {params})
        .then(responseBody),
    details: (id: number) => requests.get<Activity>(`/activities/${id}`),
    create: (activity:ActivityFormValues) => requests.post('/activities', activity),
    delete: (id: number) => requests.del(`/activities/${id}`),
    update: (activity:ActivityFormValues) => requests.put(`/activities/${activity.id}`, activity),
    attend: (id:number) => requests.post(`/activities/${id}/attend`, {}),
    
}

const Account = {
    current: () => requests.get<User>('/account/getcurrentuser'),
    login: (user:UserFormValues) => requests.post<User>('/account/login', user),
    register: (user:UserFormValues) => requests.post<User>('/account/register', user)
}

const Profiles = {
    get: (username:string) => requests.get<Profile>(`/profiles/${username}`),
    uploadPhoto: (file:Blob) => {
        let formData = new FormData();
        formData.append('File', file);
        return axios.post<Photo>('photos', formData, {
            headers: {'Content-type': 'multipart/form-data'}
        });
    },
    setMainPhoto: (id: string) => {
        requests.post(`/photos/${id}/setMain`, {})
    },
    deletePhoto: (id:string) => requests.del(`/photos/${id}`),

    updateFollowing: (username: string) => requests.post(`/follow/${username}`, {}),
    listFollowings: (username: string, predicate: string) => 
        requests.get<Profile[]>(`/follow/${username}?predicate=${predicate}`)
}

const agent = {
    Activities,
    Account,
    Profiles
};

export default agent;