
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

                    trigger={

                    }
                >   

                </Popup>

            ))}

        </List>
    )
})