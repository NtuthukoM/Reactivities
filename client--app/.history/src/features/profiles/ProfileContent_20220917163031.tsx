import React from 'react';
import { Tab } from 'semantic-ui-react';

export default function ProfileContent(){
    const panes = [
        {menuItem: 'About', render: () => <Tab.Pane>About Content</Tab.Pane>},
        {menuItem: 'Photos', render: () => <Tab.Pane>Photos Content</Tab.Pane>},
        {menuItem: 'Events', render: () => <Tab.Pane>About Content</Tab.Pane>},
        {menuItem: 'Followers', render: () => <Tab.Pane>About Content</Tab.Pane>},
        {menuItem: 'Following', render: () => <Tab.Pane>About Content</Tab.Pane>},
    ];
}