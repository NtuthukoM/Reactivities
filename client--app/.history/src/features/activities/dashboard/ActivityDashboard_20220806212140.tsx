import React from "react";
import { Grid, List } from "semantic-ui-react";

interface props{
    
}

export default function ActivityDasbord(){
    return (
        <Grid>
            <Grid.Column width='10'>
            <List>
                {
                    activities.map((activity) =>(
                        <List.Item key={activity.id}>{activity.title}</List.Item>
                    ))
                    }
          </List>   
            </Grid.Column>
        </Grid>

    )
}