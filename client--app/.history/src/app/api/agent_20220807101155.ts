import axios, { AxiosResponse } from "axios";
import { Activity } from "../models/activity";

axios.defaults.baseURL = "http://localhost:5118/api";
const responseBody = <T>(response : AxiosResponse<T>) => response.data;
const requests = {
    get : <T>(url: string) => axios.get<T>(url).then(responseBody),
    post : <T>(url: string, body: {}) => axios.post(url, body).then(responseBody),
    put : <T>(url: string, body: {}) => axios.put(url, body).then(responseBody),
    del : (url: string) => axios.delete(url).then(responseBody),

};

const Activities = {
    list: () => requests.get<Activity[]>('/activities')
}


const agent = {
    Activities
};

export default agent;