import React from "react";
import { Link } from "react-router-dom";
import { Container, Header, Segment, Image } from "semantic-ui-react";

export default function HomePage(){
    return (
       <Segment textAlign="center" inverted vertical className="masthead">
            <Container text>
                <Header inverted as='h1'>
                    <Image  />
                </Header>
            </Container>
        </Segment>
    )
}