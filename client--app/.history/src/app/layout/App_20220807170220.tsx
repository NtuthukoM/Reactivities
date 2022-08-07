import React, { Fragment } from 'react';

import { Container } from 'semantic-ui-react';
import NavBar from './NavBar';
import ActivityDasbord from '../../features/activities/dashboard/ActivityDashboard
import { observer } from 'mobx-react-lite';
import { Route } from 'react-router-dom';
import HomePage from '../../features/home/homePage';
import ActivityDashboard from '../../features/activities/dashboard/ActivityDashboard';
import ActivityForm from '../../features/activities/form/ActivityForm';

function App() {

  return (
    <Fragment>
      <NavBar></NavBar>
      <Container style={{marginTop: '7em'}}>
        <Route path='/' exact component={HomePage} />
        <Route path='/activities' exact component={ActivityDashboard} />
        <Route path='/createactivity' exact component={ActivityForm} />
      </Container>
 

    </Fragment>
  );
}

export default observer(App);
