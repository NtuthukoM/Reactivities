import { observer } from 'mobx-react-lite';
import React from 'react';
import { useStore } from '../../app/stores/store';


export default observer(function ProfileFollowings(){
    const {profileStore} = useStore();
    const {profile, loadFollowings, loadingFollowings, followings} = profileStore;

    return (
        <Tab
    )
})