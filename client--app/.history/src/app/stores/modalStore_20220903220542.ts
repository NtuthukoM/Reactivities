import { makeAutoObservable } from "mobx"


interface Modal {
    open: boolean;
    
}
export default class ModalStore {
    modal = {
        open: false,
        body: null
    }

    constructor() {
        makeAutoObservable(this);
    }

    openModal = (content: JSX.Element) => {
        this.modal.open = true;
        this.modal.body = content;
    }
}