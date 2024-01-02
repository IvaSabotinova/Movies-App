import { Button, Container, Form, Nav, Navbar, NavDropdown, Image } from 'react-bootstrap';
import { NavLink } from 'react-router-dom';

import './Header.css';

import Paths from '../../constants/Paths';

import popcornSodaImage from '/images/images-general/popcorn-soda.png';

export default function Header() {
  return (
    <Navbar expand="lg" className='header fixed-top'>
      <Container fluid>
        {/* <Navbar.Brand href="">Navbar scroll</Navbar.Brand> */}
        <Navbar.Toggle aria-controls="navbarScroll" />
        <Navbar.Collapse className='d-flex justify-content-between' id="navbarScroll" style={{height:'50px'}}>
          <Nav
          //me-auto 
            className="my-2 my-lg-0"
            style={{ maxHeight: '100px' }}
            navbarScroll
          >
            <Image src={popcornSodaImage} alt="popcornSodaImage" style={{ maxHeight: '35px' }} roundedCircle />
            <Nav.Link as={NavLink} to={Paths.Home} className="text-white" >Home</Nav.Link>
            <Nav.Link className="text-white" href="">Link</Nav.Link>
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

          <Form className="d-flex col-3">
            <Form.Control
              type="search"
              placeholder="Search movie"
              className="me-2"
              aria-label="Search"
            />
            <button className='search-button'>Search</button>
            {/* <Button variant="outline-info">Search</Button> */}
          </Form>
          <Nav>
            <Nav.Link as={NavLink} to={Paths.Register} className="text-white">Register</Nav.Link>
            <Nav.Link as={NavLink} to={Paths.Login} className="text-white">Login</Nav.Link>
            <Nav.Link as={NavLink} to={Paths.Logout} className="text-white">Logout</Nav.Link>            
          </Nav>
        </Navbar.Collapse>
      </Container>
    </Navbar>
  );
}