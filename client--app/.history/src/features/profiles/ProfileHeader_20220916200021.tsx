import React from 'react';
import { Grid, Header, Item, Segment, Statistic } from 'semantic-ui-react';


export default function ProfileHeader(){

    return (
        <Segment>
            <Grid>
                <Grid.Column width={12}>
                    <Item.Group>
                            <Item>
                                <Item.Image avatar size='small' src={'/assets/user.png'}></Item.Image>
                                <Item.Content verticalAlign='middle'>
                                        <Header as='h1' content={'Display name'} />
                                </Item.Content>
                            </Item>
                    </Item.Group>
                </Grid.Column>
                <Grid.Column width={4}>
                    <Statistic.Group widths={2}>
                        <Statistic label=></Statistic>
                    </Statistic.Group>
                </Grid.Column>
            </Grid>
        </Segment>
    )
}