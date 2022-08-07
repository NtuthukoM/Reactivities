import React, { Fragment, useEffect, useState } from 'react';

import { Container, Header, List } from 'semantic-ui-react';
import axios from 'axios';
import { Activity } from '../models/activity';
import NavBar from './NavBar';

function App() {
  const [activities, setActivities] = useState<Activity[]>([]);
  useEffect(() => {
    axios.get<Activity[]>('http://localhost:5118/api/Activities').then(response => {
      setActivities(response.data);
    });
  }, []);

  return (
    <Fragment>
      <NavBar></NavBar>

      <Container style={{marginTop: '7em'}}>

      </Container>
 

    </Fragment>
  );
}

export default App;
