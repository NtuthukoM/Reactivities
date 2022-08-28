import { ServerError } from "../models/serverError";

export default class CommonStore {
    error: ServerError | null = null;
}