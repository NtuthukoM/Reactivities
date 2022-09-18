import { observer } from 'mobx-react-lite';
import React, {useState} from 'react';
import { Button, Card, Grid, Header, Image, TabPane } from 'semantic-ui-react';
import PhotoUploadWidget from '../../app/common/imageUpload/PhotoUploadWidget';
import { Photo } from '../../app/models/profile';
import { useStore } from '../../app/stores/store';

interface Props{
    photos: Photo[] | undefined
}

export default observer( function ProfilePhotos({photos}: Props){
    const {profileStore: {isCurrentUser, uploadPhoto, uploading, setMainPhoto, loading}} = useStore();
    const [addPhotoMode, setAddPhotoMode] = useState(false);
    ,const [target, setTarget] = useState('');

    function handlePhotoUpload(file:Blob){
        uploadPhoto(file).then(() => {setAddPhotoMode(false)}) ;
    }

    return (
        <TabPane>
            <Grid>
                <Grid.Column width={16}>
                    <Header floated='left' icon='image' content='Photos'  />
                    {isCurrentUser &&
                        <Button floated='right' basic content={addPhotoMode ? 'Cancel' : 'Add Photo'}
                            onClick={() => setAddPhotoMode(!addPhotoMode)}
                        ></Button>
                    }
                </Grid.Column>
                <Grid.Column width={16}>
                    {addPhotoMode ?
                    (<PhotoUploadWidget uploadPhoto={handlePhotoUpload} uploading={uploading} />) :
                    (
                        <Card.Group itemsPerRow={5}>
                            {photos && 
                                photos.map(photo => (
                                    <Card key={photo.id}>
                                    <Image src={photo.url || '/assets/user.png'} />
                                    {isCurrentUser &&
                                        <Button.Group fluid widths={2}>
                                            <Button 
                                                basic 
                                                color='green' 
                                                content='Main'
                                                name={photo.id}
                                                disabled={photo.isMain}
                                                onClick={}
                                                />
                                        </Button.Group>
                                    }
                                </Card>
                                )) 
                            }
                        </Card.Group>
                    )}
                </Grid.Column>
            </Grid>
        </TabPane>
    )
})