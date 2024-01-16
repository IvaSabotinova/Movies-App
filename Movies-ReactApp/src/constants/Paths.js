
export const BaseUrl = "https://localhost:5000/api";

const Paths = {
    Home: '/',
    MovieDetails: '/movies/details/:movieId',
    Register: '/register',
    Login: '/login',
    Logout: '/logout',
    CreateMovie: '/create-movie',
    UpdateMovie: '/update-movie/:movieId',  
    WatchList: '/watchList/:userId',
    NotFound: '*'
}

export default Paths;