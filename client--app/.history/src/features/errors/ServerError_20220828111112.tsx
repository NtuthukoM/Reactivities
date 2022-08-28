import React from "react";
import { Container, Header } from "semantic-ui-react";
import { useStore } from "../../app/stores/store";

export default function SeverError() {
    const {commonStore} = useStore();

    return (
        <Container>
            <Header as='h1' content= />
        </Container>
    )
}