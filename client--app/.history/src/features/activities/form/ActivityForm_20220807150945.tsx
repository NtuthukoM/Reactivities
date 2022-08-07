import { observer } from "mobx-react-lite";
import React, { ChangeEvent, useState } from "react";
import { Button, Form, Segment } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";
import ActivityStore from "../../../app/stores/activityStore";
import { useStore } from "../../../app/stores/store";


export default observer( function ActivityForm(){    
    const {activityStore} = useStore();
    const initailState = activityStore.selectedActivity ?? {
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
    if(initailState.id > 0){
        activityStore.updateActivity(activity);
    }else{
        activi
    }
}

function handleOnChange(event: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>){
    const {name, value} = event.target;
    setActivity({...activity, [name]: value});
}
    return (
        <Segment clearing>
            <Form onSubmit={handleSubmit} autoComplete='off'>
                <Form.Input placeholder='Title' value={activity.title} name='title' onChange={handleOnChange}></Form.Input>
                <Form.TextArea placeholder='Description'  value={activity.description} name='description' onChange={handleOnChange} />
                <Form.Input placeholder='Category'  value={activity.category} name='category' onChange={handleOnChange}></Form.Input>
                <Form.Input placeholder='Date' type="date"  value={activity.date} name='date' onChange={handleOnChange}></Form.Input>
                <Form.Input placeholder='City'  value={activity.city} name='city' onChange={handleOnChange}></Form.Input>
                <Form.Input placeholder='Venue'  value={activity.venue} name='venue' onChange={handleOnChange}></Form.Input>
                <Button loading={submitting} positive floated="right" content='Submit' type="submit"></Button>
                <Button  floated="right" content='Cancel' onClick={() => activityStore.closeForm()} type="button"></Button>
            </Form>
        </Segment>
    )
})