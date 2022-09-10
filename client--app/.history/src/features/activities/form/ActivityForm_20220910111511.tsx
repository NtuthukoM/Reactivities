import { Formik, Form } from "formik";
import { observer } from "mobx-react-lite";
import React, {  useEffect, useState } from "react";
import { Link, useHistory, useParams } from "react-router-dom";
import { Button, Header, Segment } from "semantic-ui-react";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { useStore } from "../../../app/stores/store";
import * as Yup from 'yup';
import MyTextInput from "../../../app/common/form/MyTextInput";
import MyTextArea from "../../../app/common/form/MyTextArea";
import MySelectInput from "../../../app/common/form/MySelectInput";
import { categoryOptions } from "../../../app/common/options/CategoryOptions";
import MyDateInput from "../../../app/common/form/MyDateInput";
import { Activity, ActivityFormValues } from "../../../app/models/activity";


export default observer( function ActivityForm(){    
    const {activityStore} = useStore();
    const {loadActivity, loadingInitial } = activityStore;
    const {id} = useParams<{id:string}>();
    const history = useHistory();
    const [activity, setActivity] = useState<ActivityFormValues>(new ActivityFormValues());
const validationSchema = Yup.object({
    title: Yup.string().required('The activity title is required'),
    description: Yup.string().required('The activity description is required'),
    date: Yup.string().required('Date is required').nullable(),
    category: Yup.string().required(),
    venue: Yup.string().required(),
    city: Yup.string().required(),
});

    useEffect(() => {
        if(id)
        {
            loadActivity(parseInt(id))
            .then(activity => {
                console.log(activity);
                const model = new ActivityFormValues()
                setActivity(new ActivityFormValues(activity));
            });
        }
    }, [id, loadActivity])


function handleFormSubmit(activity: ActivityFormValues){
    if(activity.id){
        activityStore.updateActivity(activity)
        .then(() => history.push(`/activities/${activity.id}`));        
        
    }else{
        activityStore.createActivity(activity)
        .then((x) => history.push(`/activities/${x}`));      
    }
}


if(loadingInitial) return <LoadingComponent content="Loading activity..."></LoadingComponent>
    return (
        <Segment clearing>
            <Header sub color="teal" content='Activity Details' />
            <Formik 
            validationSchema={validationSchema}
            enableReinitialize 
            initialValues={activity} 
            onSubmit={values => handleFormSubmit(values)}>
                {({handleSubmit, isValid, isSubmitting, dirty}) => (
            <Form className="ui form" onSubmit={handleSubmit} autoComplete='off'>
                <MyTextInput name="title" placeholder="title" />
            <MyTextArea placeholder='Description'  rows={4} name='description' />
            <MySelectInput options={categoryOptions} placeholder='Category'  name='category'></MySelectInput>
            <MyDateInput 
                    placeholderText='Date'  
                    showTimeSelect
                    timeCaption="time"
                    dateFormat="MMMM d, yyyy h:mm aaa"
                    name='date' />
                    <Header sub color="teal" content='Location Details' />
            <MyTextInput placeholder='City' name='city'></MyTextInput>
            <MyTextInput placeholder='Venue'  name='venue'></MyTextInput>
            <Button 
                disabled={isSubmitting || !isValid || !dirty}
                loading={isSubmitting} 
                positive floated="right" 
                content='Submit' type="submit"></Button>
            <Button  floated="right" content='Cancel' as={Link} to='/activities' type="button"></Button>
        </Form>
                )}
            </Formik>


        </Segment>
    )
})