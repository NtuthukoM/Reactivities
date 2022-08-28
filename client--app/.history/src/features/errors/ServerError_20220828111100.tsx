import React from "react";
import { Container } from "semantic-ui-react";
import { useStore } from "../../app/stores/store";

export default function SeverError() {
    const {commonStore} = useStore();

    return (
        <Container>
            <Header as='h1' />
        </Container>
    )
}