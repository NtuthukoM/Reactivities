import { observer } from "mobx-react-lite";
import React from "react";
import { NavLink } from "react-router-dom";
import { Button, Container, Menu } from "semantic-ui-react";
import { useStore } from "../stores/store";


export default observer(function NavBar(){
    const {userStore: {user, lo}} = useStore();
    return (
        <Menu inverted fixed="top">
            <Container>
                <Menu.Item header as={NavLink} to='/' exact>
                    <img src="/assets/logo.png" alt="logo" style={{marginRight: 15}} />
                    Reactivities
                </Menu.Item>
                <Menu.Item name="Activities" as={NavLink} to='/activities'>

                </Menu.Item>
                <Menu.Item name="Errors" as={NavLink} to='/errors'>

                </Menu.Item>
                <Menu.Item>
                    <Button positive content='Create Activity' as={NavLink} to='/createactivity'>

                    </Button>
                </Menu.Item>
            </Container>
        </Menu>

    )
})