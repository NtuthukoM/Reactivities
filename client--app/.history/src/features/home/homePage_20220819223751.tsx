import React from "react";
import { Link } from "react-router-dom";
import { Container, Segment } from "semantic-ui-react";

export default function HomePage(){
    return (
       <Segment textAlign="center" inverted vertical className="masthead">
            <Container text>
                <Header inverted>

                </Header>
            </Container>
        </Segment>
    )
}