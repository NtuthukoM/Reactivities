import React from "react";
import { Card, Image, Icon } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";
interface Props{
    activity: Activity
}

export default function ActivityDetails({activity}:Props){
    return (
        <Card>
        <Image src={`/assets/${activity}`}  />
        <Card.Content>
          <Card.Header>Matthew</Card.Header>
          <Card.Meta>
            <span className='date'>Joined in 2015</span>
          </Card.Meta>
          <Card.Description>
            Matthew is a musician living in Nashville.
          </Card.Description>
        </Card.Content>
        <Card.Content extra>
          <a>
            <Icon name='user' />
            22 Friends
          </a>
        </Card.Content>
      </Card>
    )
}