import { observer } from "mobx-react-lite";
import React, { useEffect } from "react";
import { Grid } from "semantic-ui-react";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { useStore } from "../../../app/stores/store";
import ActivityFilters from "./ActivityFilters";
import ActivityList from "./ActivityList";


export default observer(function ActivityDasbord(){
    const {activityStore} = useStore();
    const {loadActivities, activityRegistry, setPagingParams, pagination} = activityStore; 
    useEffect(() => {
       if(activityRegistry.size <= 1) loadActivities()
      }, [activityRegistry, loadActivities]);    
      if(activityStore.loadingInitial) return (
        <LoadingComponent content='Loading App'></LoadingComponent>
      )      
    return (
        <Grid>
            <Grid.Column width='10'>
            <ActivityList></ActivityList> 
            </Grid.Column>
            <Grid.Column width='6'>
               <ActivityFilters />
            </Grid.Column>

        </Grid>

    )
})