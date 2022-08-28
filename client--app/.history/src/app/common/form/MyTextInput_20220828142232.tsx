import { useField } from "formik";
import React from "react";
import { Form } from "semantic-ui-react";

interface Props {
    name:string,
    placeholder:string
    label?: string
}

export default function MyTextInput(props:Props){
    const [name, meta] = useField(props.name);

    return (
        <Form.Field error={meta.touched }>

        </Form.Field>
    )
}