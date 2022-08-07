import React, { Fragment, useEffect, useState } from 'react';

import { Container } from 'semantic-ui-react';
import { Activity } from '../models/activity';
import NavBar from './NavBar';
import ActivityDasbord from '../../features/activities/dashboard/ActivityDashboard';
import agent from '../api/agent';
import LoadingComponent from './LoadingComponent';

function App() {
  const [activities, setActivities] = useState<Activity[]>([]);
  const [selectedActivity, setSelectActivity] = useState<Activity | undefined>(undefined);
  const [editMode, setEditMode] = useState(false);
  const [loading, setLoading] = useState(true);
  const [submitting, setSubmitting] = useState(false);

  function handleSelectActivity(id: number){
    setSelectActivity(activities.find(x => x.id === id))
  }

  function handleCancelSelectActivity(){
    setSelectActivity(undefined);
  }

  function handleFormOpen(id?: number){
    id ? handleSelectActivity(id) : handleCancelSelectActivity();
    setEditMode(true);
  }

  function handleFormClose(){
    setEditMode(false);
  }

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
    agent.Activities.delete(id).then();
    setActivities([...activities.filter(x => x.id !== id)]);
  }

  useEffect(() => {
    agent.Activities.list()
    .then(response => {
      let activities : Activity[] = [];
      response.forEach(x =>
        {
            x.date = x.date.split('T')[0];
            activities.push(x);
        });
      setActivities(activities);
      setLoading(false);
    });
  }, []);

  if(loading) return (
    <LoadingComponent content='Loading App'></LoadingComponent>
  )

  return (
    <Fragment>
      <NavBar openForm={handleFormOpen}></NavBar>

      <Container style={{marginTop: '7em'}}>
        <ActivityDasbord 
          activities={activities}
          selectedActivity={selectedActivity}
          selectActivity={handleSelectActivity}
          cancelSelectActivity={handleCancelSelectActivity}
          editMode={editMode}
          openForm={handleFormOpen}
          closeForm={handleFormClose}
          editOrCreateActivity={handleEditOrCreateActivity}
          deleteActivity={handleDeleteActivity}
          submitting={submitting}
        ></ActivityDasbord>
      </Container>
 

    </Fragment>
  );
}

export default App;
