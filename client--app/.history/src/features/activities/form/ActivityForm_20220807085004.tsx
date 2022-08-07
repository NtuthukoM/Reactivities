import React from "react";
import { Button, Form, Segment } from "semantic-ui-react";

//closeForm={closeForm} activity={selectedActivity}

interface Props {
    
}

export default function ActivityForm(){
    return (
        <Segment clearing>
            <Form>
                <Form.Input placeholder='Title'></Form.Input>
                <Form.TextArea placeholder='Description' />
                <Form.Input placeholder='Category'></Form.Input>
                <Form.Input placeholder='Date'></Form.Input>
                <Form.Input placeholder='City'></Form.Input>
                <Form.Input placeholder='Venue'></Form.Input>
                <Button positive floated="right" content='Submit' type="submit"></Button>
                <Button  floated="right" content='Cancel' type="button"></Button>
            </Form>
        </Segment>
    )
}