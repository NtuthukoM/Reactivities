import React from "react";
import { Grid, List } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";
import ActivityDetails from "../details/ActivityDetails";
import ActivityForm from "../form/ActivityForm";
import ActivityList from "./ActivityList";

interface Props{
    activities: Activity[],
    selectedActivity:Activity | undefined,
    
}

export default function ActivityDasbord({activities}: Props){
    return (
        <Grid>
            <Grid.Column width='10'>
            <ActivityList activities={activities}></ActivityList> 
            </Grid.Column>
            <Grid.Column width='6'>
                {activities[0] && 
                <ActivityDetails activity={activities[0]}></ActivityDetails>}
                <ActivityForm></ActivityForm>
            </Grid.Column>

        </Grid>

    )
}