import React from "react";
import { Header, Icon, Segment } from "semantic-ui-react";

export default function NotFound(){
    return (
        <Segment placeholder>
                <Header icon>
                    <Icon name="search"></Icon>
                    W can't find what you were looking <for className=""></for>
                </Header>
        </Segment>
    )
}