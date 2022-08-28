import React from "react";
import { NavLink } from "react-router-dom";
import { Button, Container, Menu } from "semantic-ui-react";


export default function NavBar(){
    return (
        <Menu inverted fixed="top">
            <Container>
                <Menu.Item header as={NavLink} to='/' exact>
                    <img src="/assets/logo.png" alt="logo" style={{marginRight: 15}} />
                    Reactivities
                </Menu.Item>
                <Menu.Item name="Activities" as={NavLink} to='/activities'>
                <Menu.Item name="Errors" as={NavLink} to='/activities'>

                </Menu.Item>
                <Menu.Item>
                    <Button positive content='Create Activity' as={NavLink} to='/createactivity'>

                    </Button>
                </Menu.Item>
            </Container>
        </Menu>

    )
}