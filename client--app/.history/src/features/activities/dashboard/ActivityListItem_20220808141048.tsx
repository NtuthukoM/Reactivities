import React from "react";
import { Link } from "react-router-dom";
import { Item, Button, Label } from "semantic-ui-react";
import activityStore from "../../../app/stores/activityStore";

interface Props{
    activity:Activi
}

export default function ActivityListItem(){
    

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