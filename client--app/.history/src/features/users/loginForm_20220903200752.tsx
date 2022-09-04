import { Form, Formik } from "formik";
import React from "react";
import MyTextInput from "../../app/common/form/MyTextInput";

export default function LoginForm(){


    return (
        <Formik
            initialValues={{email:'', password:''}}
            onSubmit={(values) => console.log(values) }
            >
                    {({handleSubmit}) => (
                        <Form className="ui form" 
                        onSubmit={handleSubmit} autoComplete='off'>
                                <MyTextInput
                        </Form>
                    )}
        </Formik>
    )
}