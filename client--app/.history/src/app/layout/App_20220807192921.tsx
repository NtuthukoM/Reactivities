import React, { Fragment } from 'react';

import { Container } from 'semantic-ui-react';
import NavBar from './NavBar';
import { observer } from 'mobx-react-lite';
import { Route, useLocation } from 'react-router-dom';
import HomePage from '../../features/home/homePage';
import ActivityDashboard from '../../features/activities/dashboard/ActivityDashboard';
import ActivityForm from '../../features/activities/form/ActivityForm';
import ActivityDetails from '../../features/activities/details/ActivityDetails';

function App() {
const location = useLocation();
  return (
    <Fragment>
      <Route path='/' exact component={HomePage} />
      <Route path={'/(.+)'} render={() => (
        <>
        
        </>

      )}>

      </Route>

 

    </Fragment>
  );
}

export default observer(App);
