import React, { Fragment, useEffect, useState } from 'react';

import { Container } from 'semantic-ui-react';
import { Activity } from '../models/activity';
import NavBar from './NavBar';
import ActivityDasbord from '../../features/activities/dashboard/ActivityDashboard';
import agent from '../api/agent';

function App() {
  const [activities, setActivities] = useState<Activity[]>([]);
  const [selectedActivity, setSelectActivity] = useState<Activity | undefined>(undefined);
  const [editMode, setEditMode] = useState(false);

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
    if(activity.id > 0){
      setActivities([...activities.filter(x => x.id !== activity.id), activity])
    }else {
      let maxId: number = 0;
      for(let i = 0; i < activities.length; i++){
        if(activities[i].id > maxId){
          maxId = activities[i].id;
        }
      }
      maxId++;
      activity.id = maxId;
      setActivities([...activities, activity]);
    }
    setEditMode(false);
    setSelectActivity(activity);
  }

  function handleDeleteActivity(id: number){
    setActivities([...activities.filter(x => x.id != id)]);
  }

  useEffect(() => {
    agent.Activities.list()
    .then(response => {
      setActivities(response);
    });
  }, []);

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
        ></ActivityDasbord>
      </Container>
 

    </Fragment>
  );
}

export default App;
