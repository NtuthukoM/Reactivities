import React, { Fragment } from 'react';

import { Container } from 'semantic-ui-react';
import NavBar from './NavBar';
import { observer } from 'mobx-react-lite';
import { Route, Switch, useLocation } from 'react-router-dom';
import HomePage from '../../features/home/homePage';
import ActivityDashboard from '../../features/activities/dashboard/ActivityDashboard';
import ActivityForm from '../../features/activities/form/ActivityForm';
import ActivityDetails from '../../features/activities/details/ActivityDetails';
import TestErrors from '../../features/errors/TestError';
import { ToastContainer } from 'react-toastify';
import NotFound from '../../features/errors/NotFound';

function App() {
const location = useLocation();
  return (
    <Fragment>
      <ToastContainer hideProgressBar position='top-right' />
      <Route path='/' exact component={HomePage} />
      <Route path={'/(.+)'} render={() => (
        <>
              <NavBar></NavBar>
              <Container style={{marginTop: '7em'}}>
                <Switch>
                  
                </Switch>
                <Route path='/activities' exact component={ActivityDashboard} />
                <Route path='/activities/:id' exact component={ActivityDetails} />
                <Route key={location.key}  path={['/createactivity', '/manage/:id']} exact component={ActivityForm} />
                <Route path='/errors' exact component={TestErrors} />
                <Route component={NotFound} />
              </Container>
        </>

      )}>

      </Route>

 

    </Fragment>
  );
}

export default observer(App);
