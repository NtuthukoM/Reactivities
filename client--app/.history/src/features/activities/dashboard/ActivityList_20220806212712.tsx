import React from "react";
import { Activity } from "../../../app/models/activity";

interface Props{
    activities:Activity[]
}

export default function ActivityList({activities}:Props){
    return (
<List>
                {
                    activities.map((activity) =>(
                        <List.Item key={activity.id}>{activity.title}</List.Item>
                    ))
                    }
          </List>  
    )
}