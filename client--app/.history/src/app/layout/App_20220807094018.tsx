import React, { Fragment, useEffect, useState } from 'react';

import { Container } from 'semantic-ui-react';
import axios from 'axios';
import { Activity } from '../models/activity';
import NavBar from './NavBar';
import ActivityDasbord from '../../features/activities/dashboard/ActivityDashboard';

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
    activity.id > 0 ?
    setActivities([...activities.filter(x => x.id !== activity.id), activity])
    : setActivities([...activities, activity]);
    setEditMode(false);
    setSelectActivity(activity);
  }

  function handleDeleteActivity(id: number){
    setActivities([...activities.filter()])
  }

  useEffect(() => {
    axios.get<Activity[]>('http://localhost:5118/api/Activities').then(response => {
      setActivities(response.data);
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
        ></ActivityDasbord>
      </Container>
 

    </Fragment>
  );
}

export default App;
