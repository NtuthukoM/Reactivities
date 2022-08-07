import React, { ChangeEvent, useState } from "react";
import { Button, Form, Segment } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";

interface Props {
    closeForm: () => void,
    activity: Activity | undefined
}

export default function ActivityForm({closeForm, activity:selectedActivity}: Props){
    const initailState = selectedActivity ?? {
        id: 0,
        title : '',
        date: '',
        description: '',
        category: '',
        city: '',
        venue:'',
    };

const [activity, setActivity] = useState(initailState);
function handleSubmit(){
    console.log(activity);
}

function handleOnChange(event: ChangeEvent<HTMLInputElement>){
    const {name, value} = event.target;
    setActivity({...activity, [name]: value]});
}
    return (
        <Segment clearing>
            <Form onSubmit={handleSubmit} autoComplete='off'>
                <Form.Input placeholder='Title' value={activity.title} name='title' onChange={handleOnChange}></Form.Input>
                <Form.TextArea placeholder='Description'  value={activity.description} name='description' onInput={handleOnChange} />
                <Form.Input placeholder='Category'  value={activity.category} name='category' onChange={handleOnChange}></Form.Input>
                <Form.Input placeholder='Date'  value={activity.date} name='date' onChange={handleOnChange}></Form.Input>
                <Form.Input placeholder='City'  value={activity.city} name='city' onChange={handleOnChange}></Form.Input>
                <Form.Input placeholder='Venue'  value={activity.venue} name='venue' onChange={handleOnChange}></Form.Input>
                <Button positive floated="right" content='Submit' type="submit"></Button>
                <Button  floated="right" content='Cancel' onClick={() => closeForm()} type="button"></Button>
            </Form>
        </Segment>
    )
}