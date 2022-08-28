import React from "react";
import { Message } from "semantic-ui-react";

interface Props{
    errors: string[]
}

export default function ValidationErrors({errors}: Props){
    return (
        <Message error>
            {errors && (
                <Message.List>
                    {errors.map((err:any, i) => (
                        <Message.Item key={}>

                        </Message.Item>
                    ))}
                </Message.List>
            )}
        </Message>
    )
}