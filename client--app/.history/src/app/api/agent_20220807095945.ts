import axios, { AxiosResponse } from "axios";

axios.defaults.baseURL = "http://localhost:5118/api";
const responseBody = (response : AxiosResponse) => response.data;
const requests = {
    get : (url: string) => axios.get(url).then(responseBody),
    post : (url: string) => axios.get(url).then(responseBody),
    put : (url: string) => axios.get(url).then(responseBody),
    delete : (url: string) => axios.delete(url).then(responseBody),

}