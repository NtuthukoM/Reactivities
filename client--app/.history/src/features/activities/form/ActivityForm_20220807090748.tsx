import React from "react";
import { Button, Form, Segment } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";

interface Props {
    closeForm: () => void,
    activity: Activity | undefined
}

export default function ActivityForm({closeForm, activity:seleected}: Props){
    const initailState = activity ?? {
        id: 0,
        title : '',
        date: '',
        description: '',
        category: '',
        city: '',
        venue:'',
    };
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
                <Button  floated="right" content='Cancel' onClick={() => closeForm()} type="button"></Button>
            </Form>
        </Segment>
    )
}