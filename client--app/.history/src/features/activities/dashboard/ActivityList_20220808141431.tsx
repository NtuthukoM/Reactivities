import { observer } from "mobx-react-lite";
import { SyntheticEvent, useState} from "react";
import { Link } from "react-router-dom";
import { Button, Item, Label, Segment } from "semantic-ui-react";
import { useStore } from "../../../app/stores/store";
import ActivityListItem from "./ActivityListItem";


export default observer(function ActivityList(){
    const {activityStore} = useStore();

    return (
            <Segment>
                <Item.Group divided>
                    {
                        activityStore.activitiesByDate.map(activity =>(
                            <ActivityListItem activity={activity}></ActivityListItem>
                        ))
                    }
                </Item.Group>
            </Segment>
    )
})