import React, { useState } from "react";
import { Card, Image, Button } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";

export default function ActivityDetails(){
  const {activityStore} = use();
  const {activity} = activityStore;
    return (
        <Card fluid>
        <Image src={`/assets/categoryImages/${activity.category}.jpg`}  />
        <Card.Content>
          <Card.Header>
            {activity.title}
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