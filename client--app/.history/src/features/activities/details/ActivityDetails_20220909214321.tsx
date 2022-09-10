import { observer } from "mobx-react-lite";
import React, { useEffect } from "react";
import { useParams } from "react-router-dom";
import { Grid } from "semantic-ui-react";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { useStore } from "../../../app/stores/store";
import ActivityDetailedChat from "./ActivityDetailedChat";
import ActivityDetailedInfo from "./ActivityDetailedInfo";
import ActivityDetailedSideBar from "./ActivityDetailedSideBar";
import ActivityDetailHeader from "./ActivityDetailHeader";

export default observer(function ActivityDetails(){
  const {activityStore} = useStore();
  const {selectedActivity:activity, loadActivity, loadingInitial} = activityStore;
  const {id} = useParams<{id:string}>();
  useEffect(() => {
      if(id) {
        loadActivity(parseInt(id));
      }
      
    }, [id, loadActivity]);


  if(loadingInitial || !activity) return (<LoadingComponent />);

    return (
      <Grid>
        <Grid.Column width={10}>
          <ActivityDetailHeader activity={activity}></ActivityDetailHeader>
          <ActivityDetailedInfo activity={activity}></ActivityDetailedInfo>
          <ActivityDetailedChat></ActivityDetailedChat>
        </Grid.Column>
        <Grid.Column width={6}>
          <ActivityDetailedSideBar attendees={activo}></ActivityDetailedSideBar>
        </Grid.Column>
      </Grid>
    )
})