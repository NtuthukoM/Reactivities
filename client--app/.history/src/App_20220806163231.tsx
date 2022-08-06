import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import { Header, List } from 'semantic-ui-react';
import './App.css';
import axios from 'axios';

function App() {
  const [activities, setActivities] = useState([]);
  useEffect(() => {
    axios.get('http://localhost:5118/api/Activities').then(response => {
      console.log(response);
      setActivities(response.data);
    });
  }, []);

  return (
    <div className="App">
      <Header as='h2' icon='users' content='Reactivities' />
      <List>

      </List>
      
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <List>

        </List>
        <ul>
        {
          activities.map((activity:any) =>(
            <List.Item key={activity.id}>{activity.title}</List.Item>
          ))
        }
      </ul>        
      </header>

    </div>
  );
}

export default App;
