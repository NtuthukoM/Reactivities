import { format } from "date-fns";
import React from "react";
import { Link } from "react-router-dom";
import { Item, Button,  Segment, Icon } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";
import ActivityListItemAttendee from "./ActivityListItemAttendee";

interface Props{
    activity:Activity
}

export default function ActivityListItem({activity}:Props){ 

    return (
        <Segment.Group>
            <Segment>
                <Item.Group>
                    <Item>
                        <Item.Image size="tiny" circular src='/assets/user.png' />
                        <Item.Content>
                            <Item.Header as={Link} to={`/activities/${activity.id}`}>
                                {activity.title}
                            </Item.Header>
                            <Item.Description>
                                Hosted by S'pha
                            </Item.Description>
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
                    <ActivityListItemAttendee attendees={activity.attendees}></ActivityListItemAttendee>
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