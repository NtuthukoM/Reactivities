import { observer } from 'mobx-react-lite';
import React from 'react';
import { Grid, Header, Tab } from 'semantic-ui-react';
import { useStore } from '../../app/stores/store';


export default observer(function ProfileFollowings(){
    const {profileStore} = useStore();
    const {profile, loadFollowings, loadingFollowings, followings} = profileStore;

    return (
        <Tab.Pane loading={loadingFollowings}>
            <Grid>
                <Grid.Column width={16}>
                    <Header floated='left' icon={'user'} content={`People following ${profile?.displayName}`}
                    />
                </Grid.Column>
                <Grid.Column width={16}
            </Grid>
        </Tab.Pane>
    )
})