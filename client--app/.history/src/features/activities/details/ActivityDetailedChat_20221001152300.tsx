import { Formik } from 'formik';
import { observer } from 'mobx-react-lite'
import React, { useEffect } from 'react'
import { Link } from 'react-router-dom';
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
                            <Comment key={comment.Id}>
                            <Comment.Avatar src={comment.image || '/assets/user.png'} />
                            <Comment.Content>
                                <Comment.Author as={Link} to={`/profiles/${comment.username}`}>{comment.displayName}</Comment.Author>
                                <Comment.Metadata>
                                    <div>{comment.createdAt.toDateString()}</div>
                                </Comment.Metadata>
                                <Comment.Text>{comment.body}</Comment.Text>
                            </Comment.Content>
                        </Comment>
                    ))}

                    <Formik 
                        onSubmit={(values, {resetForm}) => commentStore.addComment(values)
                                                .then(() => resetForm())} 
                        initialValues={{body: ''}}
                    >
                        {({isSubmitting})}
                    </Formik>


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