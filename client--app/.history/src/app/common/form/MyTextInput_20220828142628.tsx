import { useField } from "formik";
import React from "react";
import { Form, Label } from "semantic-ui-react";

interface Props {
    name:string,
    placeholder:string
    label?: string
}

export default function MyTextInput(props:Props){
    const [name, meta] = useField(props.name);

    return (
        <Form.Field error={meta.touched && !!meta.error}>
            <label>{props.label}</label>
            <input {...field} {...props} />
            {meta.touched && meta.error ? (
                <Label color="red" basic content={meta.error} />
            ) : }
        </Form.Field>
    )
}