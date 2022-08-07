import React, { useEffect, useState } from 'react';

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
    <div>
      <NavBar></NavBar>

      <Container>
        
      </Container>
      <List>
      {
          activities.map((activity) =>(
            <List.Item key={activity.id}>{activity.title}</List.Item>
          ))
        }
      </List>    

    </div>
  );
}

export default App;
