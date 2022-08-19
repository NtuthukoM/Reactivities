import React, { SyntheticEvent, useState } from "react";
import { Link } from "react-router-dom";
import { Item, Button, Label } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";
import { useStore } from "../../../app/stores/store";

interface Props{
    activity:Activity
}

export default function ActivityListItem({activity}:Props){
    const [target, setTarget] = useState('');
    const {activityStore} = useStore();

    function handleActivityDelete(e:SyntheticEvent<HTMLButtonElement>, id: number){
        setTarget(e.currentTarget.name);
        activityStore.deleteActivity(id);
    }
    

    return (
        <Item key={activity.id}>
        <Item.Content>
            <Item.Header as='a'>
                {activity.title}
            </Item.Header>
            <Item.Meta>
                {activity.date}
            </Item.Meta>
            <Item.Description>
                <div>{activity.description}</div>
                <div>{activity.city}, {activity.venue}</div>
            </Item.Description>
            <Item.Extra>
                <Button floated="right" content='Delete' color="red" 
                name={`del-btn-${activity.id}`}
                loading={activityStore.loading && target === `del-btn-${activity.id}` }
                onClick={(e) => {handleActivityDelete(e, activity.id)}}></Button>

                <Button floated="right" content='View' color="blue" 
                as={Link} to={`/activities/${activity.id}`} ></Button>
                <Label content={activity.category}></Label>
            </Item.Extra>

        </Item.Content>
</Item>        
    )
}