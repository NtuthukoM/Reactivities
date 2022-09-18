import React from 'react';
import { Grid, Header, Item, Segment } from 'semantic-ui-react';


export default function ProfileHeader(){

    return (
        <Segment>
            <Grid>
                <Grid.Column width={12}>
                    <Item.Group>
                            <Item>
                                <Item.Image avatar size='small' src={'/assets/user.png'}></Item.Image>
                                <Item.Content verticalAlign='middle'>
                                        <Header />
                                </Item.Content>
                            </Item>
                    </Item.Group>
                </Grid.Column>
            </Grid>
        </Segment>
    )
}