import { observer } from 'mobx-react-lite';
import React from 'react';
import { Card } from 'semantic-ui-react';
import { Profile } from '../../app/models/profile';


interface Props {
    profile:Profile
}

export default observer(function ProfileCard({profile}:Props){

    return (
        <Card>
            
        </Card>
    )
})