import React from "react";
import { Container, Menu } from "semantic-ui-react";

export default function NavBar(){
    return (
        <Menu inverted fixed="top">
            <Container>
                <Menu.Item header>
                    <img src="assets/logo.png" alt="logo" />
                </Menu.Item>
            </Container>
        </Menu>

    )
}