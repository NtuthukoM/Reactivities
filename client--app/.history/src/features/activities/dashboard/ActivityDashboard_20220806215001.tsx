import React from "react";
import { Grid, List } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";
import ActivityDetails from "../details/ActivityDetails";
import ActivityList from "./ActivityList";

interface Props{
    activities: Activity[]
}

export default function ActivityDasbord({activities}: Props){
    return (
        <Grid>
            <Grid.Column width='10'>
            <ActivityList activities={activities}></ActivityList> 
            </Grid.Column>
            <Grid.Column width='6'>
                <ActivityDetails activity={activi}></ActivityDetails>
            </Grid.Column>

        </Grid>

    )
}