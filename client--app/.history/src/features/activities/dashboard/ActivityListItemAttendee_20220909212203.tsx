
import { observer } from 'mobx-react-lite';
import React from 'react';
import { Image, List } from 'semantic-ui-react';

export default observer(function ActivityListItemAttendee(){


    return (
        <List horizontal>
            <List.Item>
                <Image size=''></Image>
            </List.Item>
        </List>
    )
})