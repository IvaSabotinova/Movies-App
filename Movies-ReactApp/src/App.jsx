import { Routes, Route } from 'react-router-dom';

import Paths from './constants/Paths';

import Header from './components/header/Header';
import Home from './components/home/Home';
import Footer from './components/footer/Footer';
import MovieDetails from './components/movie-details/MovieDetails';

function App() {
  return (
    <>
      <Header />
      {/* <Home /> */}
      <Routes>
        <Route path={Paths.Home} element={<Home />} />
        <Route path={Paths.MovieDetails} element={<MovieDetails />} />
      </Routes>
      <Footer />
    </>
  )
}

export default App;
