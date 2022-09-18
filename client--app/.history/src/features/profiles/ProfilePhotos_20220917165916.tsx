import { observer } from 'mobx-react-lite';
import React from 'react';
import { Header, TabPane } from 'semantic-ui-react';

export default observer( function ProfilePhotos(){

    return (
        <TabPane>
            <Headerader icon='image' content='Photos'  />
        </TabPane>
    )
})