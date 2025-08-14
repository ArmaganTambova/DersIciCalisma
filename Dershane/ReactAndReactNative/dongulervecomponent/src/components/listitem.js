import React from 'react'
import ListItemCss from './css/listitem.css'

export default function ListItem(props) {
  return (
    <div className='item-box'>
        <img src={props.resim} />
        <h4>{props.baslik}</h4>
    </div>
  )
}
