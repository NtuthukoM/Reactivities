import React from 'react';
import { Button, Divider, Grid, Header, Item, Reveal, Segment, Statistic } from 'semantic-ui-react';
import { Profile } from '../../app/models/profile';

interface Props {
    profile:Profile
}

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
                        <Statistic label='Followers' value={'5'}></Statistic>
                        <Statistic label='Following' value={'32'}></Statistic>
                    </Statistic.Group>
                    <Divider />
                    <Reveal animated='move'>
                        <Reveal.Content visible style={{width:'100%'}}>
                            <Button fluid color='teal' content='Following'></Button>                            
                        </Reveal.Content>
                        <Reveal.Content hidden style={{width:'100%'}}>
                            <Button 
                            basic
                            fluid 
                            color={true ? 'red' : 'green'}
                            content={true ? 'Follow' : 'Unfollow'}>
                                </Button>                            
                        </Reveal.Content>
                    </Reveal>

                    
                </Grid.Column>
            </Grid>
        </Segment>
    )
}