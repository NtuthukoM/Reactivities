import { useField } from "formik";
import React from "react";
import { Form, Label } from "semantic-ui-react";
import DatePicker from

interface Props {
    name:string,
    placeholder:string
    label?: string
}

export default function MyDateInput(props:Props){
    const [field, meta] = useField(props.name);

    return (
        <Form.Field error={meta.touched && !!meta.error}>
            <label>{props.label}</label>
            <input {...field} {...props} />
            {meta.touched && meta.error ? (
                <Label color="red" basic content={meta.error} />
            ) : null}
        </Form.Field>
    )
}