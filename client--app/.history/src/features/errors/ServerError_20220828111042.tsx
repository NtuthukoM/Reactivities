import React from "react";
import { useStore } from "../../app/stores/store";

export default function SeverError() {
    const {commonStore} = useStore();

    return (
        <Container>
            <Header />
        </Container>
    )
}