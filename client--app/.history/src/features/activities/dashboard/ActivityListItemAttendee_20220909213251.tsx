
import { observer } from 'mobx-react-lite';
import React from 'react';
import { Image, List } from 'semantic-ui-react';
import { Profile } from '../../../app/models/profile';

interface Props {
    attendees: Profile[];
}

export default observer(function ActivityListItemAttendee({attendees}:Props){


    return (
        <List horizontal>
            {attendees.map(attendee => (
                <List.Item key={attendee.username}>
                <Image size='mini' circular src={'/assets/user.png'></Image>
                </List.Item>
            ))}

        </List>
    )
})