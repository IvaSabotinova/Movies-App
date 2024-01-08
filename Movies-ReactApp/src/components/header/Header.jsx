import { useContext, useState, useEffect } from 'react';
import { NavLink, useLocation } from 'react-router-dom';
import { Button, Container, Form, Nav, Navbar, NavDropdown, Image } from 'react-bootstrap';

import './Header.css';

import Paths from '../../constants/Paths';
import AuthContext from '../../contexts/AuthContext';
import MovieContext from '../../contexts/MovieContext';

import popcornSodaImage from '/images/images-general/popcorn-soda.png';

export default function Header() {
  const { username, isAuthenticated } = useContext(AuthContext);
  const { filterMoviesBySearchTerm } = useContext(MovieContext);
  const [searchValue, setSearchValue] = useState("");
  const location = useLocation();
  const isHomePage = location.pathname === Paths.Home;

  const searchValueChangeHandler = (e) => {
    const searchTerm = e.target.value;
    setSearchValue(searchTerm);

  }

  useEffect(() => {
    filterMoviesBySearchTerm(searchValue);

  }, [searchValue])

  return (
    <Navbar expand="lg" className='header fixed-top'>
      <Container fluid>
        {/* <Navbar.Brand href="">Navbar scroll</Navbar.Brand> */}
        <Navbar.Toggle aria-controls="navbarScroll" />
        <Navbar.Collapse className='d-flex justify-content-between' id="navbarScroll" style={{ height: '50px' }}>
          <Nav
            //me-auto 
            className="my-2 my-lg-0"
            style={{ maxHeight: '100px' }}
            navbarScroll
          >
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
          {isHomePage && 
          <Form className="d-flex col-3">
            <Form.Control
              type="search"
              placeholder="Search movie by title"
              className="me-2"
              aria-label="Search"
              value={searchValue}
              onChange={searchValueChangeHandler}
            />
               {/* <span style={{ position: "relative", left: "-43px", top: "5px"}}>
            <i className="bi bi-search"></i>
          </span> */}
            {/* <button className='search-button' onClick={handleSearchClick}>Search</button> */}
            {/* <Button variant="outline-info">Search</Button> */}
          </Form>}
      
          <Nav>
            {!isAuthenticated &&
              <>
                <Nav.Link as={NavLink} to={Paths.Register} className="text-white">Register</Nav.Link>
                <Nav.Link as={NavLink} to={Paths.Login} className="text-white">Login</Nav.Link>
              </>}
            {isAuthenticated &&
              <>
                <Nav.Link>Welcome, {username}!</Nav.Link>
                <Nav.Link as={NavLink} to={Paths.Logout} className="text-white logout">Logout</Nav.Link>
              </>}
          </Nav>
        </Navbar.Collapse>
      </Container>
    </Navbar>
  );
}