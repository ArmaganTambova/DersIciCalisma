import React, { useContext } from 'react'
import {ThemaData} from '../App';

export default function Container() {
  return (
    <div style={useContext(ThemaData)}>
        <h1>React Uygulamaları</h1>
        <h2>useContext İle Componentler Arası Veri Taşıma Uygulaması</h2>
        {/* <p><b>{useContext(ThemaData)}</b></p> */}
        <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Dolore, asperiores.</p>
        <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Dolore, asperiores.</p>
        <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Dolore, asperiores.</p>
    </div>
  )
}
