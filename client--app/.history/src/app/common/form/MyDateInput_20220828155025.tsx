import { useField } from "formik";
import React from "react";
import { Form, Label } from "semantic-ui-react";
import DatePicker, {ReactDatePickerProps} from 'react-datepicker';


export default function MyDateInput(props:ReactDatePickerProps){
    const [field, meta, helpers] = useField(props.name!);

    return (
        <Form.Field error={meta.touched && !!meta.error}>
            <DatePicker 
                {...field}
                {...props}
                selected={(field.value && new Date(feild.val))}
            />
            {meta.touched && meta.error ? (
                <Label color="red" basic content={meta.error} />
            ) : null}
        </Form.Field>
    )
}