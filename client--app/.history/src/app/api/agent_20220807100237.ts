import axios, { AxiosResponse } from "axios";
import { ADDRGETNETWORKPARAMS } from "dns";

axios.defaults.baseURL = "http://localhost:5118/api";
const responseBody = (response : AxiosResponse) => response.data;
const requests = {
    get : (url: string) => axios.get(url).then(responseBody),
    post : (url: string, body: {}) => axios.post(url, body).then(responseBody),
    put : (url: string, body: {}) => axios.put(url, body).then(responseBody),
    del : (url: string) => axios.delete(url).then(responseBody),

};

const Activities = {
    list: () => requests.get('/activites')
}


const agent = {
    activities: Activities
};

export default ADDRGETNETWORKPARAMS;