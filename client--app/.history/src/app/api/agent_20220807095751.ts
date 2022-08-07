import axios from "axios";

axios.defaults.baseURL = "http://localhost:5118/api";
const responseBody = (response : ) => response.data