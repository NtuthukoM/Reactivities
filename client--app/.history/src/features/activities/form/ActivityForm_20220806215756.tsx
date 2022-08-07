import React from "react";
import { Form, Segment } from "semantic-ui-react";

export default function ActivityForm(){
    return (
        <Segment>
            <Form>
                <Form.Input placeholder='Title'></Form.Input>
                <Form.TextArea placeholder='Description' />
                <Form.Input placeholder='Category'></Form.Input>
                <Form.Input placeholder='Date'></Form.Input>
                <Form.Input placeholder='City'></Form.Input>
                <Form.Input placeholder='Venue'></Form.Input>
            </Form>
        </Segment>
    )
}