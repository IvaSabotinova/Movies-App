import { Routes, Route } from 'react-router-dom';

import Paths from './constants/Paths';
import { AuthProvider } from './context/AuthContext';

import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

import Header from './components/header/Header';
import Home from './components/home/Home';
import Footer from './components/footer/Footer';
import MovieDetails from './components/movie-details/MovieDetails';
import Register from './components/register/Register';
import Login from './components/login/Login';
import Logout from './components/logout/Logout';


function App() {
  return (
    <>
      <AuthProvider>
        <Header />
        <Routes>
          <Route path={Paths.Home} element={<Home />} />
          <Route path={Paths.MovieDetails} element={<MovieDetails />} />
          <Route path={Paths.Register} element={<Register />} />
          <Route path={Paths.Login} element={<Login />} />
          <Route path={Paths.Logout} element={<Logout />} />
        </Routes>
        <ToastContainer/>
        <Footer />
      </AuthProvider>
    </>
  )
}

export default App;
