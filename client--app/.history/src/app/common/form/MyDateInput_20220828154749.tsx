import { useField } from "formik";
import React from "react";
import { Form, Label } from "semantic-ui-react";
import DatePicker, {ReactDat} from 'react-datepicker';


export default function MyDateInput(props:Props){
    const [field, meta] = useField(props.name);

    return (
        <Form.Field error={meta.touched && !!meta.error}>
            <DatePicker 

            />
            {meta.touched && meta.error ? (
                <Label color="red" basic content={meta.error} />
            ) : null}
        </Form.Field>
    )
}