import { ErrorMessage, Form, Formik } from "formik";
import { observer } from "mobx-react-lite";
import React from "react";
import { Button, Header, Label } from "semantic-ui-react";
import MyTextInput from "../../app/common/form/MyTextInput";
import { useStore } from "../../app/stores/store";
import * as yup from 'yup';
import ValidationErrors from "../errors/ValidationErrors";

export default observer(function RegisterForm(){
    const {userStore} = useStore();

    return (
        <Formik
            initialValues={{displayName:'', username:'', email:'', password:'', error:null}}
            onSubmit={(values, {setErrors}) => userStore.register(values)
                        .catch((error) => {setErrors({error})}) }
                        validationSchema={yup.object({
                            displayName: yup.string().required(),
                            username: yup.string().required(),
                            email: yup.string().required().email(),
                            password: yup.string().required(),
                        })}
            >
                    {({handleSubmit, isSubmitting, errors, isValid, dirty}) => (
                        <Form className="ui form" 
                        onSubmit={handleSubmit} autoComplete='off'>
                            <Header as='h2' textAlign="center" color="teal" content='Reactivities Registration'></Header>
                            
                                <MyTextInput name="displayName" placeholder="Display name" />
                                <MyTextInput name="username" placeholder="Username" />
                                <MyTextInput name="email" placeholder="Email" />
                                <MyTextInput name="password" placeholder="Password" type='password' />
                                <ErrorMessage
                                    name='error'
                                    render={() => (
                                        <ValidationErrors errors={} />
                                    )}  
                                />
                                <Button type="submit" 
                                disabled={!isValid || !dirty || isSubmitting}
                                loading={isSubmitting}
                                        fluid 
                                        positive content='Register' />
                        </Form>
                    )}
        </Formik>
    )
})