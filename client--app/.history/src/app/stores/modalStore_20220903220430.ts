import { makeAutoObservable } from "mobx"
import { JsxAttribute } from "typescript";

export default class ModalStore {
    modal = {
        open: false,
        body: null
    }

    constructor() {
        makeAutoObservable(this);
    }

    openModal = (content: JsxAttribute.) {

    }
}