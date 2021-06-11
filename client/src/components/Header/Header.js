import './Header.scss'
import {Link} from 'react-router-dom'

export const Header = () => (
  <header className="header">
    <nav className="header-nav">
      <Link to="/" className="header-nav__heading">
        CoreNETStore
      </Link>
    </nav>
  </header>
)