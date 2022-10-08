import { observer } from "mobx-react-lite";
import React from "react";
import { Calendar } from "react-calendar";
import { Header, Menu } from "semantic-ui-react";
import { useStore } from "../../../app/stores/store";

export default observer(function ActivityFilters () {
    const {activityStore: {predicate, setPredicate}} = useStore();

    return (
        <>
            <Menu size="large" vertical style={{width:'100%', marginTop: '25px'}}>
                <Header icon='filter' attached color="teal" content='Filters'></Header>
                <Menu.Item 
                    active={predicate.has('all')} 
                    content="All activities" 
                    
                    />
                <Menu.Item content="I'm going" />
                <Menu.Item content="I'm hosting" />
            </Menu>
            <Header></Header>
            <Calendar></Calendar>
        </>
    )
})