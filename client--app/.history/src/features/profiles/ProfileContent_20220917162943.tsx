import React from 'react';
import { Tab } from 'semantic-ui-react';

export default function ProfileContent(){
    const panes = [
        {menuItem: 'About', render: () => <Tab.Pane></Tab.Pane>},
    ];
}