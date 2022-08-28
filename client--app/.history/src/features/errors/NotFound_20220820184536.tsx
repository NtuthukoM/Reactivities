import React from "react";
import { Button, Header, Icon, Segment } from "semantic-ui-react";

export default function NotFound(){
    return (
        <Segment placeholder>
                <Header icon>
                    <Icon name="search"></Icon>
                    We can't find what you were looking for...
                    <Segment.Inline>
                        <Button></Button>
                    </Segment.Inline>
                </Header>
        </Segment>
    )
}