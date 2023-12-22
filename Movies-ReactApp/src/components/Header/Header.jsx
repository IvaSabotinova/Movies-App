import { Button, Container, Form, Nav, Navbar, NavDropdown, Image } from 'react-bootstrap';

import './Header.css';

import popcornSodaImage from '/images/images-general/popcorn-soda.png';

export default function Header() {
  return (
    <Navbar expand="lg" className='header'>
      <Container fluid>
        {/* <Navbar.Brand href="">Navbar scroll</Navbar.Brand> */}
        <Navbar.Toggle aria-controls="navbarScroll" />
        <Navbar.Collapse id="navbarScroll">
          <Nav
            className="me-auto my-2 my-lg-0"
            style={{ maxHeight: '100px' }}
            navbarScroll
          >
            <Image src={popcornSodaImage} alt="popcorn-soda" style={{ maxHeight: '35px' }} roundedCircle />
            <Nav.Link href="">Home</Nav.Link>
            <Nav.Link href="">Link</Nav.Link>
            <NavDropdown title="Link" id="navbarScrollingDropdown">
              <NavDropdown.Item href="">Action</NavDropdown.Item>
              <NavDropdown.Item href="">
                Another action
              </NavDropdown.Item>
              <NavDropdown.Divider />
              <NavDropdown.Item href="">
                Something else here
              </NavDropdown.Item>
            </NavDropdown>
          </Nav>

          <Form className="d-flex col-4">
            <Form.Control
              type="search"
              placeholder="Search movie"
              className="me-2"
              aria-label="Search"
            />
            <Button variant="outline-success">Search</Button>
          </Form>

        </Navbar.Collapse>
      </Container>
    </Navbar>
  );
}