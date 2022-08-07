import { observer } from "mobx-react-lite";
import React, { useEffect } from "react";
import { Grid } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";
import { useStore } from "../../../app/stores/store";
import ActivityDetails from "../details/ActivityDetails";
import ActivityForm from "../form/ActivityForm";
import ActivityList from "./ActivityList";


export default observer(function ActivityDasbord(){
    useEffect(() => {
        activityStore.loadActivities()
      }, [activityStore]);    
        const {activityStore} = useStore();
    return (
        <Grid>
            <Grid.Column width='10'>
            <ActivityList></ActivityList> 
            </Grid.Column>
            <Grid.Column width='6'>
                {activityStore.selectedActivity && !activityStore.editMode &&
                <ActivityDetails></ActivityDetails>}

                { activityStore.editMode &&
                    <ActivityForm></ActivityForm>
                }
            </Grid.Column>

        </Grid>

    )
})