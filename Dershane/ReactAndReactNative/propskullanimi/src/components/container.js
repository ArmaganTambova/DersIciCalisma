import React from 'react'
import Header from './header'

export default function container(props) {
  return (
    <div style={{width: "400px", height: "400px", border: "1px solid silver", margin: "0px auto"}}>
        <Header veri={props.deneme}>Merhaba Ben Bir Child Component'im</Header>
        <p>{props.aciklama}</p>
    </div>
  )
}
