import { observer } from "mobx-react-lite";
import { Fragment } from "react";
import { Item, Label, Segment } from "semantic-ui-react";
import { useStore } from "../../../app/stores/store";
import ActivityListItem from "./ActivityListItem";


export default observer(function ActivityList(){
    const {activityStore} = useStore();

    return (
        <>
            {activityStore.getGroupedActivities.map(([group, activities]) => (
                <Fragment>
                    
                </Fragment>
            ))}
        </>
            <Segment>
                <Item.Group divided>
                    {
                        activityStore.getGroupedActivities.map(activity =>(
                            <ActivityListItem activity={activity}></ActivityListItem>
                        ))
                    }
                </Item.Group>
            </Segment>
    )
})