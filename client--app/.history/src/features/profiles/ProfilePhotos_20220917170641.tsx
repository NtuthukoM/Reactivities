import { observer } from 'mobx-react-lite';
import React from 'react';
import { Card, Header, Image, TabPane } from 'semantic-ui-react';
import { Photo } from '../../app/models/profile';

interface Props{
    photos: Photo[] | undefined
}

export default observer( function ProfilePhotos({photos}: Props){

    return (
        <TabPane>
            <Header icon='image' content='Photos'  />
            <Card.Group itemsPerRow={5}>
                {photos && 
                    photos.map(photo => (
                        <Card key={photo.id}>
                        <Image src={'/assets/user.png'} />
                    </Card>
                    )) 
                }

                <Card>
                    <Image src={'/assets/user.png'} />
                </Card>
                <Card>
                    <Image src={'/assets/user.png'} />
                </Card>
                <Card>
                    <Image src={'/assets/user.png'} />
                </Card>
            </Card.Group>
        </TabPane>
    )
})