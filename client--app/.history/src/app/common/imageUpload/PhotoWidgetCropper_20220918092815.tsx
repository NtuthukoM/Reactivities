import React from 'react';
import { Cropper } from 'react-cropper';
import 'cropperjs/dist/cropper.css';

interface Props {
    
}

export default function PhotoWidgetCropper() {

    return (
        <Cropper
            src={'image'}
            style={{width:'100%', height:'200px'}}
            initialAspectRatio={1}
            aspectRatio={1}
            preview={'.img-preview'}
            guides={false}
            viewMode={1}
            autoCropArea={1}
            background={false}
        >

        </Cropper>
    )
}