import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';

function App() {
  const [activities, setActivities] = useState([]);
  useEffect(() => {
    axios.get('https://localhost:7118/api/Activities').then(response => {
      console.log(response);
      setActivities(response.data);
    });
  }, []);

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
      </header>
      <ul>
        {
          activities.map((activity :any) =>(
            <li>{activity.Id}</li>
          ))
        }
      </ul>
    </div>
  );
}

export default App;
