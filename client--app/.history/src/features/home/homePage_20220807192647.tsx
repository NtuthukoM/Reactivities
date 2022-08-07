import React from "react";
import { Link } from "react-router-dom";
import { Container } from "semantic-ui-react";

export default function HomePage(){
    return (
        <Container style={{marginTop:'7em'}}>
            <h2>Home</h2>
            <h5>Go to <Link to='/'>activities</Link></h5>
        </Container>
    )
}