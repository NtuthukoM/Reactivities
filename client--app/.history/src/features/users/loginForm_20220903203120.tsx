import { Form, Formik } from "formik";
import { observer } from "mobx-react-lite";
import React from "react";
import { Button } from "semantic-ui-react";
import MyTextInput from "../../app/common/form/MyTextInput";
import { useStore } from "../../app/stores/store";

export default observer(function LoginForm(){
    const {userStore} = useStore();

    return (
        <Formik
            initialValues={{email:'', password:''}}
            onSubmit={(values) => console.log(values) }
            >
                    {({handleSubmit, is}) => (
                        <Form className="ui form" 
                        onSubmit={handleSubmit} autoComplete='off'>
                                <MyTextInput name="email" placeholder="Email" />
                                <MyTextInput name="password" placeholder="Password" type='password' />
                                <Button type="submit" fluid positive content='Login' />
                        </Form>
                    )}
        </Formik>
    )
})