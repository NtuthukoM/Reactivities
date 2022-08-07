import React, { Fragment, useEffect, useState } from 'react';

import { Container, Header, List } from 'semantic-ui-react';
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

  useEffect(() => {
    axios.get<Activity[]>('http://localhost:5118/api/Activities').then(response => {
      setActivities(response.data);
    });
  }, []);

  return (
    <Fragment>
      <NavBar openForm={handel}></NavBar>

      <Container style={{marginTop: '7em'}}>
        <ActivityDasbord 
          activities={activities}
          selectedActivity={selectedActivity}
          selectActivity={handleSelectActivity}
          cancelSelectActivity={handleCancelSelectActivity}
          editMode={editMode}
          openForm={handleFormOpen}
          closeForm={handleFormClose}
        ></ActivityDasbord>
      </Container>
 

    </Fragment>
  );
}

export default App;
