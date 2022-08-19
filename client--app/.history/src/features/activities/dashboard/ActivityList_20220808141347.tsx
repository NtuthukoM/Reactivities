import { observer } from "mobx-react-lite";
import { SyntheticEvent, useState} from "react";
import { Link } from "react-router-dom";
import { Button, Item, Label, Segment } from "semantic-ui-react";
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

                        ))
                    }
                </Item.Group>
            </Segment>
    )
})