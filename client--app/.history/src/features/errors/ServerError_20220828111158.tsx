import React from "react";
import { Container, Header } from "semantic-ui-react";
import { useStore } from "../../app/stores/store";

export default function SeverError() {
    const {commonStore} = useStore();

    return (
        <Container>
            <Header as='h1' content='Server error' />
            <Header as='h5' color="red" content />
        </Container>
    )
}