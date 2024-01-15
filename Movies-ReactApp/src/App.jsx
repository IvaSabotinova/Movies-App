import { Routes, Route } from 'react-router-dom';

import Paths from './constants/Paths';
import { AuthProvider } from './contexts/AuthContext';
import { MovieProvider } from './contexts/MovieContext';

import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

import Header from './components/header/Header';
import Home from './components/home/Home';
import Footer from './components/footer/Footer';
import MovieDetails from './components/movie-details/MovieDetails';
import Register from './components/register/Register';
import Login from './components/login/Login';
import Logout from './components/logout/Logout';
import NotFound from './components/not-found/NotFound';
import MovieCreateUpdate from './components/movie-create-update/MovieCreateUpdate';
import WatchList from './components/watch-list/WatchList';

function App() {
  return (
    <>
      <AuthProvider>
        <MovieProvider>
          <Header />
          <Routes>
            <Route path={Paths.Home} element={<Home />} />
            <Route path={Paths.MovieDetails} element={<MovieDetails />} />
            <Route path={Paths.Register} element={<Register />} />
            <Route path={Paths.Login} element={<Login />} />
            <Route path={Paths.Logout} element={<Logout />} />
            <Route path={Paths.CreateMovie} element={<MovieCreateUpdate />} />
            <Route path={Paths.UpdateMovie} element={<MovieCreateUpdate />} />           
            <Route path={Paths.WatchList} element={<WatchList />} />           
            <Route path={Paths.NotFound} element={<NotFound />} />
          </Routes>
          <ToastContainer />
          <Footer />
        </MovieProvider>
      </AuthProvider>
    </>
  )
}

export default App;
