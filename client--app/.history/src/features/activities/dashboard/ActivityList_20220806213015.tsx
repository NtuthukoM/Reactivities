import React from "react";
import { Item, List, Segment } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";

interface Props{
    activities:Activity[]
}

export default function ActivityList({activities}:Props){
    return (
            <Segment>
                <Item.Group divided>
                    <activities className="map"></activities>
                </Item.Group>
            </Segment>

        //     <List>
        //         {
        //             activities.map((activity) =>(
        //                 <List.Item key={activity.id}>{activity.title}</List.Item>
        //             ))
        //             }
        //   </List>  
    )
}