import axios, { AxiosError, AxiosResponse } from "axios";
import { toast } from "react-toastify";
import { Activity } from "../models/activity";
import { store } from "../stores/store";

axios.defaults.baseURL = "http://localhost:5118/api";
const responseBody = <T>(response : AxiosResponse<T>) => response.data;

const sleep = (delay: number) =>{
    return new Promise((resolve) => {
        setTimeout(resolve, delay);

    })
};

axios.interceptors.response.use(async response => {
        await sleep(1000);
        return response;
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
                        //toast.error("server error");

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
    list: () => requests.get<Activity[]>('/activities'),
    details: (id: number) => requests.get<Activity>(`/activities/${id}`),
    create: (activity:Activity) => requests.post('/activities', activity),
    delete: (id: number) => requests.del(`/activities/${id}`),
    update: (activity:Activity) => requests.put(`/activities/${activity.id}`, activity),

}


const agent = {
    Activities
};

export default agent;