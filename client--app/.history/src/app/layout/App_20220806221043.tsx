import React, { Fragment, useEffect, useState } from 'react';

import { Container, Header, List } from 'semantic-ui-react';
import axios from 'axios';
import { Activity } from '../models/activity';
import NavBar from './NavBar';
import ActivityDasbord from '../../features/activities/dashboard/ActivityDashboard';

function App() {
  const [activities, setActivities] = useState<Activity[]>([]);
  const [selectedActivity, setSelectedActivity] = useState<Activity | undefined>(undefined);

  function handleSelectedActivity(id: number){
    setSelectedActivity(activities.find(x => x.id === id))
  }

  function handleCancelSelectActivity(){
    
  }

  useEffect(() => {
    axios.get<Activity[]>('http://localhost:5118/api/Activities').then(response => {
      setActivities(response.data);
    });
  }, []);

  return (
    <Fragment>
      <NavBar></NavBar>

      <Container style={{marginTop: '7em'}}>
        <ActivityDasbord activities={activities}></ActivityDasbord>
      </Container>
 

    </Fragment>
  );
}

export default App;
