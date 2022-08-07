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
      <Route path={/}>

      </Route>
      <NavBar></NavBar>
      <Container style={{marginTop: '7em'}}>
        <Route path='/activities' exact component={ActivityDashboard} />
        <Route path='/activities/:id' exact component={ActivityDetails} />
        <Route key={location.key}  path={['/createactivity', '/manage/:id']} exact component={ActivityForm} />
      </Container>
 

    </Fragment>
  );
}

export default observer(App);
