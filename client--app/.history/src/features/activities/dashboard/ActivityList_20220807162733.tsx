import { observer } from "mobx-react-lite";
import { SyntheticEvent, useState} from "react";
import { Button, Item, Label, List, Segment } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";
import { useStore } from "../../../app/stores/store";


export default observer(function ActivityList(){
    const [target, setTarget] = useState('');
    const {activityStore} = useStore();

    function handleActivityDelete(e:SyntheticEvent<HTMLButtonElement>, id: number){
        setTarget(e.currentTarget.name);
        activityStore.deleteActivity(id);
    }

    return (
            <Segment>
                <Item.Group divided>
                    {
                        activityStore.activitiesByDate.map(activity =>(
                            <Item key={activity.id}>
                                    <Item.Content>
                                        <Item.Header as='a'>
                                            {activity.title}
                                        </Item.Header>
                                        <Item.Meta>
                                            {activity.date}
                                        </Item.Meta>
                                        <Item.Description>
                                            <div>{activity.description}</div>
                                            <div>{activity.city}, {activity.venue}</div>
                                        </Item.Description>
                                        <Item.Extra>
                                            <Button floated="right" content='Delete' color="red" 
                                            name={`del-btn-${activity.id}`}
                                            loading={activityStore.loading && target === `del-btn-${activity.id}` }
                                            onClick={(e) => {handleActivityDelete(e, activity.id)}}></Button>
                                            <Button floated="right" content='View' color="blue" 
                                            onClick={() => {activityStore.setSelectedActivity(activity.id)}}></Button>
                                            <Label content={activity.category}></Label>
                                        </Item.Extra>

                                    </Item.Content>
                            </Item>
                        ))
                    }
                </Item.Group>
            </Segment>
    )
})