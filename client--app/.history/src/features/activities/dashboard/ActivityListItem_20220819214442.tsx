import React, { SyntheticEvent, useState } from "react";
import { Link } from "react-router-dom";
import { Item, Button, Label, Segment } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";
import { useStore } from "../../../app/stores/store";

interface Props{
    activity:Activity
}

export default function ActivityListItem({activity}:Props){
    const [target, setTarget] = useState('');
    const {activityStore} = useStore();

    function handleActivityDelete(e:SyntheticEvent<HTMLButtonElement>, id: number){
        setTarget(e.currentTarget.name);
        activityStore.deleteActivity(id);
    }
    

    return (
        <Segment.Group>
            <Segment>
                <Item.Group>
                    <Item>
                        <Item.Image size="tiny" circular src='/assets/user.png' />
                        <Item.Content>
                            <Item.Header
                        </Item.Content>
                    </Item>
                </Item.Group>
            </Segment>
        </Segment.Group>
    )
}