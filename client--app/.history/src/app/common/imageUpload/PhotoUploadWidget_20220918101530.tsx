import React, { useState, useEffect } from 'react';
import { Button, Grid, Header, Image } from 'semantic-ui-react';
import PhotoWidgetCropper from './PhotoWidgetCropper';
import PhotoWidgetDropZone from './PhotoWidgetDropZone';

interface Props {
    uploading: boolean,
    uploadPhoto: (file: B)
}

export default function PhotoUploadWidget(){
    const [files, setFiles] = useState<any>([]);
    const [cropper, setCropper] = useState<Cropper>();

    function onCrop(){
        if(cropper){
            cropper.getCroppedCanvas()
                .toBlob(blob => console.log(blob));
        }
    }

    useEffect(() => {
        return () => {
            files.forEach((file:any) => {
                URL.revokeObjectURL(file.preview)
            });
        }
    }, [files]);

    return (
        <Grid>
            <Grid.Column width={4}>
                <Header sub color='teal' content='Step 1 - Add Photo' />
                <PhotoWidgetDropZone setFiles={setFiles} />
            </Grid.Column>
            <Grid.Column width={1} />
            <Grid.Column width={4}>
                <Header sub color='teal' content='Step 2 - Resize Image' />
                {files && files.length > 0 && (
                    <PhotoWidgetCropper setCropper={setCropper} imagePreview={files[0].preview} />
                    
                )}
            </Grid.Column>
            <Grid.Column width={1} />
            <Grid.Column width={4}>
                <Header sub color='teal' content='Step 3 - Preview and uplaod' />                
                {files && files.length > 0 && 
                    <>
                    <div className='img-preview' style={{ minHeight:'200px', overflow: 'hidden'}}></div>
                    <Button.Group widths={2}>
                        <Button onClick={onCrop} positive icon='check' />
                        <Button onClick={() => setFiles([])} icon='close' />
                    </Button.Group>
                    </>
                }
            </Grid.Column>
        </Grid>
    )
}