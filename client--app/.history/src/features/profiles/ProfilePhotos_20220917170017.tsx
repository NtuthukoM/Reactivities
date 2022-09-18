import { observer } from 'mobx-react-lite';
import React from 'react';
import { Card, Header, Image, TabPane } from 'semantic-ui-react';

export default observer( function ProfilePhotos(){

    return (
        <TabPane>
            <Header icon='image' content='Photos'  />
            <Card.Group itemsPerRow={5}>
                <Image src={'/assets/user.png'} />
            </Card.Group>
        </TabPane>
    )
})