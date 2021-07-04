import './ImageContainer.scss'
import {useEffect, useState} from 'react'

export const ImageContainer = ({ image }) => {
  const [loaded, setLoaded] = useState(false)
  
  useEffect(() => {
      setLoaded(true)
  }, [])
  
  return(
    <div className="image-container-main">
      <img src={image.url} alt="product_img" className={`image-container-main__img ${loaded? 'image-container-main__img--loaded' : ''}`}/>
    </div>
  )
}