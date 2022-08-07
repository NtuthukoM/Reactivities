import React, { useEffect } from "react";
import { Link, useParams } from "react-router-dom";
import { Card, Image, Button } from "semantic-ui-react";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { useStore } from "../../../app/stores/store";

export default function ActivityDetails(){
  const {activityStore} = useStore();
  const {selectedActivity:activity, loadActivity} = activityStore;
  const {id} = useParams<{id:string}>();
  if(id) {
    useEffect(() => {
      
    });
  }

  if(!activity) return (<LoadingComponent />);

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
            <Button basic content='Edit' color="blue" as={Link} to={`/activities/${activity.id}`}></Button>
            <Button basic content='Cancel' color="grey" as={Link} to='/activities'></Button>
            </Button.Group>
        </Card.Content>
      </Card>
    )
}