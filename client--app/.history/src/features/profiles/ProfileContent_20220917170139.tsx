import React from 'react';
import { Tab } from 'semantic-ui-react';
import ProfilePhotos from './ProfilePhotos';

export default function ProfileContent(){
    const panes = [
        {menuItem: 'About', render: () => <Tab.Pane>About Content</Tab.Pane>},
        {menuItem: 'Photos', render: () => <ProfilePhotos/>},
        {menuItem: 'Events', render: () => <Tab.Pane>Events Content</Tab.Pane>},
        {menuItem: 'Followers', render: () => <Tab.Pane>Followers Content</Tab.Pane>},
        {menuItem: 'Following', render: () => <Tab.Pane>Following Content</Tab.Pane>},
    ];

    return (
        <Tab 
            menu={{fluid: true, verical: true}}
            menuPosition='right'
            panes={panes}
        />
    )
}