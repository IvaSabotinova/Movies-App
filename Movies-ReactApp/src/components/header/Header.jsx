import { useContext } from 'react';
import { NavLink } from 'react-router-dom';
import { Container, Nav, Navbar, Image } from 'react-bootstrap';

import './Header.css';

import Paths from '../../constants/Paths';
import AuthContext from '../../contexts/AuthContext';

import popcornSodaImage from '/images/images-general/popcorn-soda.png';

export default function Header() {
  const { username, isAuthenticated } = useContext(AuthContext);

  return (
    <Navbar expand="lg" className='header fixed-top'>
      <Container fluid>
        {/* <Navbar.Brand href="">Navbar scroll</Navbar.Brand> */}
        <Navbar.Toggle aria-controls="navbarScroll" />
        <Navbar.Collapse className='d-flex justify-content-between' id="navbarScroll" style={{ height: '50px' }}>
          <Nav className="my-2 my-lg-0" style={{ maxHeight: '100px' }} navbarScroll>
            <Image src={popcornSodaImage} alt="popcornSodaImage" style={{ maxHeight: '35px' }} roundedCircle />
            <Nav.Link as={NavLink} to={Paths.Home} className="text-white" >Home</Nav.Link>
            {isAuthenticated && <Nav.Link as={NavLink} to={Paths.CreateMovie} className="text-white" >Add Movie</Nav.Link>}
            {/* <NavDropdown title="Link" id="navbarScrollingDropdown">
              <NavDropdown.Item href="">Action</NavDropdown.Item>
              <NavDropdown.Item href="">
                Another action
              </NavDropdown.Item>
              <NavDropdown.Divider />
              <NavDropdown.Item href="">
                Something else here
              </NavDropdown.Item>
            </NavDropdown> */}
          </Nav>
          <Nav>
            {isAuthenticated &&
              <Nav.Link
                className="text-white me-5"
                style={{ fontWeight: "600", fontSize: "22px", fontFamily: "cursive" }}>
                Welcome, {username}!
              </Nav.Link>}
          </Nav>
          <Nav>
            {!isAuthenticated &&
              <>
                <Nav.Link as={NavLink} to={Paths.Register} className="text-white">Register</Nav.Link>
                <Nav.Link as={NavLink} to={Paths.Login} className="text-white">Login</Nav.Link>
              </>}
            {isAuthenticated && <Nav.Link as={NavLink} to={Paths.Logout} className="text-white logout">Logout</Nav.Link>}
          </Nav>
        </Navbar.Collapse>
      </Container>
    </Navbar>
  );
}