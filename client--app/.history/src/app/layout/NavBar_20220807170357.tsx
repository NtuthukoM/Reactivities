import React from "react";
import { NavLink } from "react-router-dom";
import { Button, Container, Menu } from "semantic-ui-react";
import { useStore } from "../stores/store";


export default function NavBar(){
    const {activityStore} = useStore();
    return (
        <Menu inverted fixed="top">
            <Container>
                <Menu.Item header as={NavLink} to='/'>
                    <img src="/assets/logo.png" alt="logo" style={{marginRight: 15}} />
                    Reactivities
                </Menu.Item>
                <Menu.Item name="Activities" as={NavLink} to='/activities'>

                </Menu.Item>
                <Menu.Item>
                    <Button positive content='Create Activity' onClick={() => activityStore.openForm()}>

                    </Button>
                </Menu.Item>
            </Container>
        </Menu>

    )
}