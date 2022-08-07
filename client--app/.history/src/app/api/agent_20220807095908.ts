import axios, { AxiosResponse } from "axios";

axios.defaults.baseURL = "http://localhost:5118/api";
const responseBody = (response : AxiosResponse) => response.data;
const requests = {
    get : (url: string) => axios.get(url)

}
