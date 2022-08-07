import React, { Fragment, useEffect, useState } from 'react';

import { Container } from 'semantic-ui-react';
import { Activity } from '../models/activity';
import NavBar from './NavBar';
import ActivityDasbord from '../../features/activities/dashboard/ActivityDashboard';
import agent from '../api/agent';
import LoadingComponent from './LoadingComponent';
import { useStore } from '../stores/store';
import { observer } from 'mobx-react-lite';
import { Route } from 'react-router-dom';
import HomePage from '../../features/home/homePage';
import ActivityDashboard from '../../features/activities/dashboard/ActivityDashboard';
import ActivityForm from '../../features/activities/form/ActivityForm';

function App() {

  const {activityStore} = useStore();


  useEffect(() => {
    activityStore.loadActivities()
  }, [activityStore]);

  if(activityStore.loadingInitial) return (
    <LoadingComponent content='Loading App'></LoadingComponent>
  )

  return (
    <Fragment>
      <NavBar></NavBar>

      <Container style={{marginTop: '7em'}}>
        <Route path='/' exact component={HomePage} />
        <Route path='/activities' exact component={ActivityDashboard} />
        <Route path='/createactivity' component={ActivityForm} />
      </Container>
 

    </Fragment>
  );
}

export default observer(App);
