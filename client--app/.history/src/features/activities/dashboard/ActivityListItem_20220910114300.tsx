import { format } from "date-fns";
import React from "react";
import { Link } from "react-router-dom";
import { Item, Button,  Segment, Icon, Label } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";
import ActivityListItemAttendee from "./ActivityListItemAttendee";

interface Props{
    activity:Activity
}

export default function ActivityListItem({activity}:Props){ 

    return (
        <Segment.Group>
            <Segment>
                {activity.isCancelled && 
                (
                    <Label color="red" attached="top" style={textAlign:'cen'} >Cancelled</Label>
                )}
                <Item.Group>
                    <Item>
                        <Item.Image size="tiny" circular src='/assets/user.png' />
                        <Item.Content>
                            <Item.Header as={Link} to={`/activities/${activity.id}`}>
                                {activity.title}
                            </Item.Header>
                            <Item.Description>
                                Hosted by {activity.host?.displayName}
                            </Item.Description>
                            {activity.isHost && (
                                <Item.Description>
                                    <Label basic color="orange">You are hosting</Label>
                                </Item.Description>
                            )}
                            {activity.isGoing && !activity.isHost && (
                                <Item.Description>
                                    <Label basic color="green">You are going</Label>
                                </Item.Description>
                            )}                            
                        </Item.Content>
                    </Item>
                </Item.Group>
            </Segment>
            <Segment>
                <span>
                    <Icon name="clock" /> {format(activity.date!, 'dd MMM yyyy h:m aa')}
                    <Icon name="marker" /> {activity.venue}
                </span>
            </Segment>
            <Segment secondary>
                    <ActivityListItemAttendee attendees={activity.attendees!}></ActivityListItemAttendee>
            </Segment>
            <Segment clearing>
                <span> {activity.description} </span>
                <Button 
                    as={Link}
                    to={`/activities/${activity.id}`}
                    color='teal'
                    floated="right"
                    content='View'
                />
            </Segment>
        </Segment.Group>
    )
}