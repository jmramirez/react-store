import './ProductImage.scss'
import {ProductImageThumb} from '../ProductImageThumb/ProductImageThumb'
import {useEffect, useState} from 'react'

export const ProductImage = ({ images }) => {
  const [imagesList, setImagesList] = useState(images)
  const [image, setImage] = useState(images[0])
  const [imageId, setImageId] = useState('')
  
  useEffect(() => {
    const filteredImage = images.filter(imageSelected => imageSelected.id !== image.id)
    setImagesList(filteredImage)
  }, [imageId, image.id, images])
  
  const changeImage = (imageId) => {
    const newImage = images.find(image => image.id === imageId)
    setImage(newImage)
    setImageId(imageId)
  }
  
  return (
    <div className="image-container">
      <div className="image-container-main">
        <img src={image.url} alt="product_img" className="image-container-main__img"/>
      </div>
      <div className="image-container-thumbs">
        <ul className="image-container-thumbs__list">
          {imagesList.map((image) => (
            <li key={image.id}>
              <ProductImageThumb image={image} changeImage={changeImage}/>
            </li>
          ))}
        </ul>
      </div>
    </div>
  )
}