
import { observer } from 'mobx-react-lite';
import React from 'react';
import { Link } from 'react-router-dom';
import { Image, List, Popup } from 'semantic-ui-react';
import { Profile } from '../../../app/models/profile';

interface Props {
    attendees: Profile[];
}

export default observer(function ActivityListItemAttendee({attendees}:Props){


    return (
        <List horizontal>
            {attendees.map(attendee => (
                <Popup
                    key={attendee.username}
                    hoverable
                    trigger={
                        <List.Item key={attendee.username} as={Link} to={`/profiles/${attendee.username}`}>
                        <Image size='mini' circular src={attendee.image || '/assets/user.png'}></Image>
                        </List.Item>
                    }
                >   
                <Popup.Content>
                    <Profil
                </Popup.Content>
                </Popup>

            ))}

        </List>
    )
})