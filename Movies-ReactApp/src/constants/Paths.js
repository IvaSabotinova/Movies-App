
//export const BaseUrl = "https://localhost:7224/api";
export const BaseUrl = "https://localhost:5000/api";

const Paths = {
    Home: '/',
    MovieDetails: '/movies/details/:movieId',
    Register: '/register',
    Login: '/login',
    Logout: '/logout',
    CreateMovie: '/create-movie',
    UpdateMovie: '/update-movie/:movieId',
    StarRating: '/star-rating',
    NotFound: '*'
}

export default Paths;