import React from "react";
import { Form, Segment } from "semantic-ui-react";

export default function ActivityForm(){
    return (
        <Segment>
            <Form>
                <Form.Input placeholder='Title'></Form.Input>
            </Form>
        </Segment>
    )
}