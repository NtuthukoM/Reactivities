import React, { Fragment, useEffect, useState } from 'react';

import { Container } from 'semantic-ui-react';
import { Activity } from '../models/activity';
import NavBar from './NavBar';
import ActivityDasbord from '../../features/activities/dashboard/ActivityDashboard';
import agent from '../api/agent';
import LoadingComponent from './LoadingComponent';
import { useStore } from '../stores/store';
import { observer, Observer } from 'mobx-react-lite';

function App() {

  const {activityStore} = useStore();

  const [activities, setActivities] = useState<Activity[]>([]);
  const [selectedActivity, setSelectActivity] = useState<Activity | undefined>(undefined);
  const [editMode, setEditMode] = useState(false);
  const [submitting, setSubmitting] = useState(false);


  function handleEditOrCreateActivity(activity: Activity){
    setSubmitting(true);
    if(activity.id > 0){
      agent.Activities.update(activity).then(() =>{
        setActivities([...activities.filter(x => x.id !== activity.id), activity]);
        setSelectActivity(activity);
        setEditMode(false);
        setSubmitting(false);
      });
    }else {
      let maxId: number = 0;
      for(let i = 0; i < activities.length; i++){
        if(activities[i].id > maxId){
          maxId = activities[i].id;
        }
      }
      maxId++;
      agent.Activities.create(activity).then(() => {
        activity.id = maxId;
        setActivities([...activities, activity]);
        setSelectActivity(activity);
        setEditMode(false);
        setSubmitting(false);        

      });
    }
    setEditMode(false);
    setSelectActivity(activity);
  }

  function handleDeleteActivity(id: number){
    setSubmitting(true);
    agent.Activities.delete(id).then(() => {
        setActivities([...activities.filter(x => x.id !== id)]);
        setSubmitting(false);
    });
  }

  useEffect(() => {
    activityStore.loadActivities()
  }, [activityStore]);

  if(activityStore.loadingInitial) return (
    <LoadingComponent content='Loading App'></LoadingComponent>
  )

  return (
    <Fragment>
      <NavBar></NavBar>

      <Container style={{marginTop: '7em'}}>
        <ActivityDasbord 
          activities={activityStore.activities}
          editOrCreateActivity={handleEditOrCreateActivity}
          deleteActivity={handleDeleteActivity}
          submitting={submitting}
        ></ActivityDasbord>
      </Container>
 

    </Fragment>
  );
}

export default observer(App);
