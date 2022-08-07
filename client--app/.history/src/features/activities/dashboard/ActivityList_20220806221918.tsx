import React from "react";
import { Button, Item, Label, List, Segment } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";

interface Props{
    selectActivity: (id: number) => void,
    activities:Activity[]
}

export default function ActivityList({activities, selectActivity}:Props){
    return (
            <Segment>
                <Item.Group divided>
                    {
                        activities.map(activity =>(
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
                                            <Button floated="right" content='View' color="blue" onClick={selectActivity()}></Button>
                                            <Label content={activity.category}></Label>
                                        </Item.Extra>

                                    </Item.Content>
                            </Item>
                        ))
                    }
                </Item.Group>
            </Segment>
    )
}