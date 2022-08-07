import React from "react";
import { Button, Container, Menu } from "semantic-ui-react";

interface Props {
    openForm:(id: number) => void
}

export default function NavBar({openForm}){
    return (
        <Menu inverted fixed="top">
            <Container>
                <Menu.Item header>
                    <img src="/assets/logo.png" alt="logo" style={{marginRight: 15}} />
                    Reactivities
                </Menu.Item>
                <Menu.Item name="Activities">

                </Menu.Item>
                <Menu.Item>
                    <Button positive content='Create Activity'>

                    </Button>
                </Menu.Item>
            </Container>
        </Menu>

    )
}