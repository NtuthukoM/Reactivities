import React from "react";
import { Link } from "react-router-dom";
import { Container, Header, Segment, Image } from "semantic-ui-react";

export default function HomePage(){
    return (
       <Segment textAlign="center" inverted vertical className="masthead">
            <Container text>
                <Header inverted as='h1'>
                    <Image 
                        size="massive" 
                        src='/assests/logo.png'
                        alt='logo'
                        style={{marginBottom:'12px'}}  />
                    Reactivities
                </Header>
                <Header as='h2' inverted>

                </Header>
            </Container>
        </Segment>
    )
}