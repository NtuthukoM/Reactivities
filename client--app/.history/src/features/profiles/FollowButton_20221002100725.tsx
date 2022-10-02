import React from 'react';
import { Button, Reveal } from 'semantic-ui-react';


export default function FollowButton(){

    return (
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
    )
}