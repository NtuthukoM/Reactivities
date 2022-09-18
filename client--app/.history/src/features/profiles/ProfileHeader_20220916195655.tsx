import React from 'react';
import { Grid, Item, Segment } from 'semantic-ui-react';


export default function ProfileHeader(){

    return (
        <Segment>
            <Grid>
                <Grid.Column width={12}>
                    <Item.Group>
                            <Item>
                                <Item.Image></Item.Image>
                                </Item>
                    </Item.Group>
                </Grid.Column>
            </Grid>
        </Segment>
    )
}