import React from "react";
import { Grid, List } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";

interface Props{
    activities: Activity[]
}

export default function ActivityDasbord(props: Props){
    return (
        <Grid>
            <Grid.Column width='10'>
            <List>
                {
                    props.activities.map((activity) =>(
                        <List.Item key={activity.id}>{activity.title}</List.Item>
                    ))
                    }
          </List>   
            </Grid.Column>
        </Grid>

    )
}