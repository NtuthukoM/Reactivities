import { observer } from 'mobx-react-lite';
import React, {useState} from 'react';
import { Card, Grid, Header, Image, TabPane } from 'semantic-ui-react';
import { Photo } from '../../app/models/profile';
import { useStore } from '../../app/stores/store';

interface Props{
    photos: Photo[] | undefined
}

export default observer( function ProfilePhotos({photos}: Props){
    const {profileStore: {isCurrentUser}} = useStore();
    const [addPhotoMode, setAddPhotoMode] = useState();
    return (
        <TabPane>
            <Grid>
                <Grid.Column>

            <Header icon='image' content='Photos'  />
                </Grid.Column>
            </Grid>
            <Card.Group itemsPerRow={5}>
                {photos && 
                    photos.map(photo => (
                        <Card key={photo.id}>
                        <Image src={photo.url || '/assets/user.png'} />
                    </Card>
                    )) 
                }
            </Card.Group>
        </TabPane>
    )
})