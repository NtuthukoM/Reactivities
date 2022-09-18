import React from 'react';
import { Cropper } from 'react-cropper';
import 'cropperjs/dist/cropper.css';


export default function PhotoWidgetCropper() {

    return (
        <Cropper
            src={'image'}
            style={{width:'100%', height=100p}}
        >

        </Cropper>
    )
}