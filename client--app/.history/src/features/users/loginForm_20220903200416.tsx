import { Formik } from "formik";
import React from "react";

export default function LoginForm(){


    return (
        <Formik
            initialValues={{email:'', password:''}}
            >

        </Formik>
    )
}