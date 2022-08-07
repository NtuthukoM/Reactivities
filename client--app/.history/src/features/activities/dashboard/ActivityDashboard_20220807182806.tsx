import { observer } from "mobx-react-lite";
import React, { useEffect } from "react";
import { Grid } from "semantic-ui-react";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { Activity } from "../../../app/models/activity";
import { useStore } from "../../../app/stores/store";
import ActivityDetails from "../details/ActivityDetails";
import ActivityForm from "../form/ActivityForm";
import ActivityList from "./ActivityList";


export default observer(function ActivityDasbord(){
    const {activityStore} = useStore();
    useEffect(() => {
        activityStore.loadActivities()
      }, [activityStore]);    
      if(activityStore.loadingInitial) return (
        <LoadingComponent content='Loading App'></LoadingComponent>
      )      
    return (
        <Grid>
            <Grid.Column width='10'>
            <ActivityList></ActivityList> 
            </Grid.Column>
            <Grid.Column width='6'>
                <h2>Acti</h2>
            </Grid.Column>

        </Grid>

    )
})