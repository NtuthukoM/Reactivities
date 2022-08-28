import React from "react";
import { Container, Header, Segment } from "semantic-ui-react";
import { useStore } from "../../app/stores/store";

export default function SeverError() {
    const {commonStore} = useStore();

    return (
        <Container>
            <Header as='h1' content='Server error' />
            <Header as='h5' color="red" content={commonStore.error?.message} />
            {
                commonStore.error?.details &&
                <Segment>
                    <Header as='h4' content='Stack trace'   />
                </Segment>
            }
        </Container>
    )
}