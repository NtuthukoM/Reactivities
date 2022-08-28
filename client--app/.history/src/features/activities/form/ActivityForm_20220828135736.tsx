import { Formik, Form, Field } from "formik";
import { observer } from "mobx-react-lite";
import React, { ChangeEvent, useEffect, useState } from "react";
import { Link, useHistory, useParams } from "react-router-dom";
import { Button, Segment } from "semantic-ui-react";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { useStore } from "../../../app/stores/store";


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
            <Formik enableReinitialize initialValues={activity} onSubmit={values => console.log(values)}>
                {({values: activity, handleChange, handleSubmit}) => (
            <Form className="ui form" onSubmit={handleSubmit} autoComplete='off'>
            <Field placeholder='Title'  name='title' onChange={handleChange}></Field>
            <Field placeholder='Description'   name='description' onChange={handleChange} />
            <Field placeholder='Category'  name='category' onChange={handleChange}></Field>
            <Field placeholder='Date' type="date"  name='date' onChange={handleChange}></Field>
            <Field placeholder='City' name='city' onChange={handleChange}></Field>
            <Field placeholder='Venue'  name='venue' onChange={handleChange}></Field>
            <Button loading={activityStore.loading} positive floated="right" content='Submit' type="submit"></Button>
            <Button  floated="right" content='Cancel' as={Link} to='/activities' type="button"></Button>
        </Form>
                )}
            </Formik>


        </Segment>
    )
})