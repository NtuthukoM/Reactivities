import React from 'react';
import { Grid, Header } from 'semantic-ui-react';

export default function PhotoUploadWidget(){

    return (
        <Grid>
            <Grid.Column width={4}>
                <Header sub color='teal' content=' Add Photo - Step 1' />
            </Grid.Column>
        </Grid>
    )
}