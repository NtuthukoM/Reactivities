import { observer } from 'mobx-react-lite';
import React, { SyntheticEvent } from 'react';
import { Button, Reveal } from 'semantic-ui-react';
import { Profile } from '../../app/models/profile';
import { useStore } from '../../app/stores/store';


interface Props {
    profile: Profile
}

export default observer(function FollowButton({profile}:Props){
    const {profileStore, userStore} = useStore();
    const {updateFollowing, loading} = profileStore;

    function handleFollow(e:SyntheticEvent, username: string){
        e.preventDefault();
        profile.following ? updateFollowing(username, false):
            updateFollowing(username, true);
    }

    if(userStore.user?.username === profile.username) return null;
    return (
        <Reveal animated='move'>
        <Reveal.Content visible style={{width:'100%'}}>
            <Button fluid color='teal' 
            content='Following'></Button>                            
        </Reveal.Content>
        <Reveal.Content hidden style={{width:'100%'}}>
            <Button 
            basic
            fluid 
            color={true ? 'red' : 'green'}
            content={true ? 'Follow' : 'Unfollow'}>
                </Button>                            
        </Reveal.Content>
    </Reveal>        
    )
})