import { observer } from "mobx-react-lite";
import React from "react";
import { Modal } from "semantic-ui-react";
import { useStore } from "../../stores/store";

export default observer(function ModalContainer() {
    
    const {modalStore} = useStore();

    return (
        <Modal open={}>

        </Modal>
    )
})