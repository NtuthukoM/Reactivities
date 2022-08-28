import { useField } from "formik";
import React from "react";

interface Props {
    name:string,
    placeholder:string
    label?: string
}

export default function MyTextInput(props:Props){
    const [name, meta] = useField(props.name)
    return (
        
    )
}