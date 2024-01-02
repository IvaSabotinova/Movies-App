import { Routes, Route } from 'react-router-dom';

import Paths from './constants/Paths';

import Header from './components/header/Header';
import Home from './components/home/Home';
import Footer from './components/footer/Footer';
import MovieDetails from './components/movie-details/MovieDetails';
import Register from './components/register/Register';
import Login from './components/login/Login';

function App() {
  return (
    <>
      <Header />     
      <Routes>
        <Route path={Paths.Home} element={<Home />} />
        <Route path={Paths.MovieDetails} element={<MovieDetails />} />    
        <Route path={Paths.Register} element={<Register />} />    
        <Route path={Paths.Login} element={<Login />} />    
      </Routes>
      <Footer />
    </>
  )
}

export default App;
