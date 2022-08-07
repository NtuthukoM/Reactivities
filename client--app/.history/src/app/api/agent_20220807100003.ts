import axios, { AxiosResponse } from "axios";

axios.defaults.baseURL = "http://localhost:5118/api";
const responseBody = (response : AxiosResponse) => response.data;
const requests = {
    get : (url: string) => axios.get(url).then(responseBody),
    post : (url: string, body) => axios.post(url).then(responseBody),
    put : (url: string) => axios.put(url).then(responseBody),
    del : (url: string) => axios.delete(url).then(responseBody),

}
