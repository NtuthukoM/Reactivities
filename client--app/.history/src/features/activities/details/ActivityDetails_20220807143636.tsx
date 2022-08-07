import React, { useState } from "react";
import { Card, Image, Button } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";
import { useStore } from "../../../app/stores/store";

export default function ActivityDetails(){
  const {activityStore} = useStore();
  const {selectedActivity} = activityStore;
    return (
        <Card fluid>
        <Image src={`/assets/categoryImages/${selectedActivity.category}.jpg`}  />
        <Card.Content>
          <Card.Header>
            {selectedActivity.title}
          </Card.Header>
          <Card.Meta>
            <span>{activity.date}</span>
          </Card.Meta>
          <Card.Description>
            {activity.description}
          </Card.Description>
        </Card.Content>
        <Card.Content extra>
          <Button.Group widths='2'>
            <Button basic content='Edit' color="blue" onClick={() => {openForm(activity.id)}}></Button>
            <Button basic content='Cancel' color="grey" onClick={()=>{ cancelSelectActivity()}}></Button>
            </Button.Group>
        </Card.Content>
      </Card>
    )
}