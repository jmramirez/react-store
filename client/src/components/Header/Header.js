import './Header.scss'
import {Container, Navbar} from "react-bootstrap";

export const Header = () => (
    <Navbar bg="dark" variant="dark" expand="lg">
        <Container>
            <Navbar.Brand href="/">React Store</Navbar.Brand>
        </Container>
    </Navbar>
)