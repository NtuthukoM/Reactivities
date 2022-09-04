import React from "react";
import { Header, Menu } from "semantic-ui-react";

export default function ActivityFilters () {
    return (
        <>
            <Menu size="large" vertical style={{width:'100%'}}>
                <Header icon='filter' attached color="teal" content='Filters'></Header>
                <Menu.Item content="All activities" />
                <Menu.Item content="I'm going" />
                <Menu.Item content="I'm hosting" />
            </Menu>
            <Header>
                
            </Header>
        </>
    )
}