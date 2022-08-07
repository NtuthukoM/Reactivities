import React from "react";
import { Grid } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";
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
        const {activity}
    return (
        <Grid>
            <Grid.Column width='10'>
            <ActivityList 
                activities={activities} 
                selectActivity={selectActivity}
                deleteActivity={deleteActivity}
                submitting={submitting}
            ></ActivityList> 
            </Grid.Column>
            <Grid.Column width='6'>
                {selectedActivity && !editMode &&
                <ActivityDetails activity={selectedActivity} 
                cancelSelectActivity={cancelSelectActivity}
                openForm={openForm}
                ></ActivityDetails>}

                { editMode &&
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