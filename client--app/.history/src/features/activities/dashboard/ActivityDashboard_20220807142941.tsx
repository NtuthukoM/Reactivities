import React from "react";
import { Grid } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";
import { useStore } from "../../../app/stores/store";
import ActivityDetails from "../details/ActivityDetails";
import ActivityForm from "../form/ActivityForm";
import ActivityList from "./ActivityList";

interface Props{
    activities: Activity[],
    editOrCreateActivity: (a:Activity) => void,
    deleteActivity: (id:number) => void,
    submitting: boolean
}

export default function ActivityDasbord({activities,  editOrCreateActivity, 
    deleteActivity, submitting}: Props){
        const {activityStore} = useStore();
    return (
        <Grid>
            <Grid.Column width='10'>
            <ActivityList 
                activities={activities} 
                deleteActivity={deleteActivity}
                submitting={submitting}
            ></ActivityList> 
            </Grid.Column>
            <Grid.Column width='6'>
                {activityStore.selectedActivity && !activityStore.editMode &&
                <ActivityDetails activity={activityStore.selectedActivity} 
                cancelSelectActivity={activityStore.cancelSelectedActivity}
                openForm={openForm}
                ></ActivityDetails>}

                { activityStore.editMode &&
                    <ActivityForm closeForm={closeForm} 
                    activity={selectedActivity}
                    editOrCreateActivity={editOrCreateActivity}
                    submitting={submitting}
                    ></ActivityForm>
                }
            </Grid.Column>

        </Grid>

    )
}