import React from "react";
import { Calendar } from "react-calendar";
import { Header, Menu } from "semantic-ui-react";

export default function ActivityFilters () {
    return (
        <>
            <Menu size="large" vertical style={{width:'100%', margin}}>
                <Header icon='filter' attached color="teal" content='Filters'></Header>
                <Menu.Item content="All activities" />
                <Menu.Item content="I'm going" />
                <Menu.Item content="I'm hosting" />
            </Menu>
            <Header></Header>
            <Calendar></Calendar>
        </>
    )
}