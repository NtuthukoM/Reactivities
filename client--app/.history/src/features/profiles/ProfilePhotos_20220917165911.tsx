import { observer } from 'mobx-react-lite';
import React from 'react';
import { TabPane } from 'semantic-ui-react';

export default observer( function ProfilePhotos(){

    return (
        <TabPane>
            <Header icon='image' content='Photos'  />
        </TabPane>
    )
})