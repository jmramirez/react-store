import './ProductImageThumb.scss'

export  const ProductImageThumb = ({ image, changeImage }) => (
  <div className="thumbnail-container" onClick={() => changeImage(image.id)}>
    <img src={image.url} alt="prod_img" className="thumbnail-container__image" />
  </div>
)