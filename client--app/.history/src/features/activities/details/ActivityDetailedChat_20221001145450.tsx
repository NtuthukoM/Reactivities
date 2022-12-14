import { observer } from 'mobx-react-lite'
import React, { useEffect } from 'react'
import {Segment, Header, Comment, Form, Button} from 'semantic-ui-react';
import { useStore } from '../../../app/stores/store';

interface Props {
    activityId: number;
}

export default observer(function ActivityDetailedChat({activityId}:Props) {
    const {commentStore} = useStore();

    useEffect(() => {
        if(activityId > 0){
            commentStore.creatHubbConnection(activityId);
        }
        return () => {
            commentStore.clearComments();
        }
    }, [commentStore, activityId]);
    return (
        <>
            <Segment
                textAlign='center'
                attached='top'
                inverted
                color='teal'
                style={{border: 'none'}}
            >
                <Header>Chat about this event</Header>
            </Segment>
            <Segment attached>
                <Comment.Group>
                    {commentStore.comments.map((comment)=>(
                            <Comment>
                            <Comment.Avatar src={comment.image}/>
                            <Comment.Content>
                                <Comment.Author as='a'>{comment.displayName}</Comment.Author>
                                <Comment.Metadata>
                                    <div>Today at 5:42PM</div>
                                </Comment.Metadata>
                                <Comment.Text>{comment.body}</Comment.Text>
                                <Comment.Actions>
                                    <Comment.Action>Reply</Comment.Action>
                                </Comment.Actions>
                            </Comment.Content>
                        </Comment>
                    ))}


                    <Comment>
                        <Comment.Avatar src='/assets/user.png'/>
                        <Comment.Content>
                            <Comment.Author as='a'>Joe Henderson</Comment.Author>
                            <Comment.Metadata>
                                <div>5 days ago</div>
                            </Comment.Metadata>
                            <Comment.Text>Dude, this is awesome. Thanks so much</Comment.Text>
                            <Comment.Actions>
                                <Comment.Action>Reply</Comment.Action>
                            </Comment.Actions>
                        </Comment.Content>
                    </Comment>

                    <Form reply>
                        <Form.TextArea/>
                        <Button
                            content='Add Reply'
                            labelPosition='left'
                            icon='edit'
                            primary
                        />
                    </Form>
                </Comment.Group>
            </Segment>
        </>

    )
})