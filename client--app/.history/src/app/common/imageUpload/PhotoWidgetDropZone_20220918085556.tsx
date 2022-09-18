import React, {useCallback} from 'react'
import {useDropzone} from 'react-dropzone';

interface Props {
    setFiles: (files:any) => void
}

export default function PhotoWidgetDropZone({setFiles}: Props) {
    const dzStyles = {
        border: 'dashed 3px #eee',
        borderColor: '#eee',
        borderRadius: '5px',
        paddingTop: '30px',
        textAlign: 'center',
        height: 200
    };

    const dzActive = {
        borderColor: 'green'
    }

  const onDrop = useCallback((acceptedFiles: any) => {
    setFiles(acceptedFiles.map((files:any)=));
  }, [])
  const {getRootProps, getInputProps, isDragActive} = useDropzone({onDrop})

  return (
    <div {...getRootProps()}>
      <input {...getInputProps()} />
      {
        isDragActive ?
          <p>Drop the files here ...</p> :
          <p>Drag 'n' drop some files here, or click to select files</p>
      }
    </div>
  )
}