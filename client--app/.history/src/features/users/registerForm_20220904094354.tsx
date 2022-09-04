import { ErrorMessage, Form, Formik } from "formik";
import { observer } from "mobx-react-lite";
import React from "react";
import { Button, Header, Label } from "semantic-ui-react";
import MyTextInput from "../../app/common/form/MyTextInput";
import { useStore } from "../../app/stores/store";
import * as yup from 'yup';

export default observer(function RegisterForm(){
    const {userStore} = useStore();

    return (
        <Formik
            initialValues={{displayName:'', username:'', email:'', password:'', error:null}}
            onSubmit={(values, {setErrors}) => userStore.register(values)
                        .catch((error) => {setErrors({error:'Invalid email or password'})}) }
                        validationSchema={yup.object({
                            displayname: yup.string().required(),
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
                                        <Label style={{marginBottom:'10px'}} basic
                                                color="red"
                                                content={errors.error}></Label>
                                    )}  
                                />
                                <Button type="submit" 
                                disabled={!isva}
                                loading={isSubmitting}
                                        fluid 
                                        positive content='Login' />
                        </Form>
                    )}
        </Formik>
    )
})