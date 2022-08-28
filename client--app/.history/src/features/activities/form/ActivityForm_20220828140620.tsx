import { Formik, Form, Field } from "formik";
import { observer } from "mobx-react-lite";
import React, { ChangeEvent, useEffect, useState } from "react";
import { Link, useHistory, useParams } from "react-router-dom";
import { Button, Segment } from "semantic-ui-react";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { useStore } from "../../../app/stores/store";
import * as Yup from 'yup';


export default observer( function ActivityForm(){    
    const {activityStore} = useStore();
    const {loadActivity, loadingInitial } = activityStore;
    const {id} = useParams<{id:string}>();
    const history = useHistory();
    const [activity, setActivity] = useState({
        id: 0,
        title : '',
        date: '',
        description: '',
        category: '',
        city: '',
        venue:'',
    });
const validationSchema = Yup.object({
    title: Yup.string().required('The activity title is required')
});

    useEffect(() => {
        if(id)
        {
            loadActivity(parseInt(id))
            .then(activity => {
                console.log(activity);
                setActivity(activity!);
            });
        }
    }, [id, loadActivity])


// function handleSubmit(){
//     if(activity.id > 0){
//         activityStore.updateActivity(activity)
//         .then(() => history.push(`/activities/${activity.id}`));        
        
//     }else{
//         activityStore.createActivity(activity)
//         .then((x) => history.push(`/activities/${x}`));      
//     }
// }

// function handleOnChange(event: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>){
//     const {name, value} = event.target;
//     setActivity({...activity, [name]: value});
// }

if(loadingInitial) return <LoadingComponent content="Loading activity..."></LoadingComponent>
    return (
        <Segment clearing>
            <Formik 
            validat
            enableReinitialize 
            initialValues={activity} 
            onSubmit={values => console.log(values)}>
                {({handleSubmit}) => (
            <Form className="ui form" onSubmit={handleSubmit} autoComplete='off'>
            <Field placeholder='Title'  name='title'></Field>
            <Field placeholder='Description'   name='description' />
            <Field placeholder='Category'  name='category'></Field>
            <Field placeholder='Date' type="date"  name='date'></Field>
            <Field placeholder='City' name='city'></Field>
            <Field placeholder='Venue'  name='venue'></Field>
            <Button loading={activityStore.loading} positive floated="right" content='Submit' type="submit"></Button>
            <Button  floated="right" content='Cancel' as={Link} to='/activities' type="button"></Button>
        </Form>
                )}
            </Formik>


        </Segment>
    )
})