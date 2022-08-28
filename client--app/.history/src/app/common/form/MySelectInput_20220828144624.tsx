import { useField } from "formik";
import React from "react";
import { Form, Label, Select } from "semantic-ui-react";

interface Props {
    name:string,
    placeholder:string,
    options:any,
    label?: string
}

export default function MySelectInput(props:Props){
    const [field, meta, helpers] = useField(props.name);

    return (
        <Form.Field error={meta.touched && !!meta.error}>
            <label>{props.label}</label>
            <Select
                clearable
                options={props.options}
                value={field.value || null}
                onChange={(e, d) => helpers.setValue(d)}
                onBlur={()=> helpers.}
            ></Select>
            {meta.touched && meta.error ? (
                <Label color="red" basic content={meta.error} />
            ) : null}
        </Form.Field>
    )
}