import axios, { AxiosError, AxiosResponse } from "axios";
import { Activity } from "../models/activity";

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
},(error: AxiosError));
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