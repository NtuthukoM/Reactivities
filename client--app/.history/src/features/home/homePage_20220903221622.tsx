import { observer } from "mobx-react-lite";
import React from "react";
import { Link } from "react-router-dom";
import { Container, Header, Segment, Image, Button } from "semantic-ui-react";
import { useStore } from "../../app/stores/store";
import LoginForm from "../users/loginForm";

export default observer(function HomePage(){
    const {userStore, modalStore} = useStore();
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
                    <>
                        <Header as='h2' inverted>
                                Welcome to Reactivities
                        </Header>
                        <Button size="huge" inverted as={Link} to='/activities'>
                            Go to activities
                        </Button>                    
                    </>
                ) : (
                    <>
                        <Button size="huge" inverted onClick={() => modalStore.openModal(<LoginForm/>)}>
                            Login
                        </Button>      
                        <Button size="huge" inverted onClick={() => modalStore.openModal(<>>)}>
                            Register
                        </Button>                                         
                    </>
                )}

            </Container>
        </Segment>
    )
})