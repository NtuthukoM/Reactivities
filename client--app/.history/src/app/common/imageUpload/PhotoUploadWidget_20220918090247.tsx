import React, { useState } from 'react';
import { Grid, Header } from 'semantic-ui-react';
import PhotoWidgetDropZone from './PhotoWidgetDropZone';

export default function PhotoUploadWidget(){
    const [files, setFiles] = useState([]);
    return (
        <Grid>
            <Grid.Column width={4}>
                <Header sub color='teal' content='Step 1 - Add Photo' />
                <PhotoWidgetDropZone setFiles={setfi} />
            </Grid.Column>
            <Grid.Column width={1} />
            <Grid.Column width={4}>
                <Header sub color='teal' content='Step 2 - Resize Image' />
                {files && files.length > 0 && (

                )}
            </Grid.Column>
            <Grid.Column width={1} />
            <Grid.Column width={4}>
                <Header sub color='teal' content='Step 3 - Preview and uplaod' />
            </Grid.Column>
        </Grid>
    )
}