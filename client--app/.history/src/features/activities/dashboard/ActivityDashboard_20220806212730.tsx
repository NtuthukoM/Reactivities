import React from "react";
import { Grid, List } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";

interface Props{
    activities: Activity[]
}

export default function ActivityDasbord({activities}: Props){
    return (
        <Grid>
            <Grid.Column width='10'>
            <Act 
            </Grid.Column>
        </Grid>

    )
}