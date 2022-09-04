import { ErrorMessage, Form, Formik } from "formik";
import { observer } from "mobx-react-lite";
import React from "react";
import { Button, Header, Label } from "semantic-ui-react";
import MyTextInput from "../../app/common/form/MyTextInput";
import { useStore } from "../../app/stores/store";

export default observer(function RegisterForm(){
    const {userStore} = useStore();

    return (
        <Formik
            initialValues={{displayName:'', username:'', email:'', password:'', error:null}}
            onSubmit={(values, {setErrors}) => userStore.register(values)
                        .catch((error) => {setErrors({error:'Invalid email or password'})}) }
            >
                    {({handleSubmit, isSubmitting, errors}) => (
                        <Form className="ui form" 
                        onSubmit={handleSubmit} autoComplete='off'>
                            <Header as='h2' textAlign="center" color="teal" content='Reactivities Regis'></Header>
                            
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
                                loading={isSubmitting}
                                        fluid 
                                        positive content='Login' />
                        </Form>
                    )}
        </Formik>
    )
})