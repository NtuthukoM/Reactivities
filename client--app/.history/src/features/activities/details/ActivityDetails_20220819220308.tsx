import { observer } from "mobx-react-lite";
import React, { useEffect } from "react";
import { Link, useParams } from "react-router-dom";
import { Card, Image, Button, Grid } from "semantic-ui-react";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { useStore } from "../../../app/stores/store";
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
          <ActivityDetailHeader></ActivityDetailHeader>
        </Grid.Column>
      </Grid>
    )
})