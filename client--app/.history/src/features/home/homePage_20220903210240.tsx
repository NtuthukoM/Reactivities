import { observer } from "mobx-react-lite";
import React from "react";
import { Link } from "react-router-dom";
import { Container, Header, Segment, Image, Button } from "semantic-ui-react";
import { useStore } from "../../app/stores/store";

export default observer(function HomePage(){
    const {userStore} = useStore();
    return (
       <Segment textAlign="center" inverted vertical className="masthead">
            <Container text>
                <Header inverted as='h1'>
                    <Image 
                        size="massive" 
                        src='/assets/logo.png'
                        alt='logo'
                        style={{marginBottom:'12px'}}  />
                    Reactivities
                </Header>
                {userStore.isLoggedIn ? 
                (
                    
                )}
                <Header as='h2' inverted>
                        Welcome to Reactivities
                </Header>
                <Button size="huge" inverted as={Link} to='/login'>
                    Login
                </Button>
            </Container>
        </Segment>
    )
})