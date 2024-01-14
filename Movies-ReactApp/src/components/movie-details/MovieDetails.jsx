import { useState, useEffect, useContext } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import { toast } from 'react-toastify';

import './MovieDetails.css';

import * as movieService from '../../services/movieService';
import { formatDetailsDate } from '../../utils/dateUtil';
import { pathToUrl } from '../../utils/pathsUtil';
import AuthContext from '../../contexts/AuthContext';
import MovieContext from '../../contexts/MovieContext';
import Paths from '../../constants/Paths';
import StarRating from '../star-rating/StarRating';


export default function MovieDetails() {
    const [movie, setMovie] = useState({});
    const { movieId } = useParams();
    const { userId, username } = useContext(AuthContext);
    const { deleteMovieHandler } = useContext(MovieContext)
    const navigate = useNavigate();

    useEffect(() => {
        movieService.getMovieDetails(movieId)
            .then((res) => setMovie(res.result))
    }, [movieId]);

    const deleteMovie = (e) => {
        const hasConfirmed = confirm(`Are you sure you want to delete movie ${movie.title}?`);
        if (hasConfirmed) {
            toast.promise(
                deleteMovieHandler(movieId),
                {
                    pending: 'Processing your request...',
                    success: 'Movie deleted successfully! 👌',
                    error: 'Error encountered 🤯'
                },
                {
                    theme: "dark",
                }
            )
            navigate(Paths.Home);
        }
    }

    const handleRatingUpdate = async () => {
        const updatedMovie = await movieService.getMovieDetails(movieId);       
        setMovie(updatedMovie.result);
    }

    return (
        <div className="movie-details">
            <div className="movie-image">
                <img src={movie.imageUrl} alt="" />
            </div>
            <div className="movie-allInfo">
                <h2>{movie.title}</h2>
                <div className="rating-stars">
                    <span className="bolded">Rate the movie: </span>
                    <StarRating
                        movieId={movieId}
                        title={movie.title}
                        userId={userId}
                        onRatingUpdate={handleRatingUpdate} />
                </div>
                <div className="rating-duration">                
                    <div>
                    <span className="bolded">Users rating: </span>
                        <span className="span-star">
                            <svg
                                xmlns="http://www.w3.org/2000/svg"
                                viewBox="0 0 20 20"
                                fill="#fcc419"
                                stroke="#fcc419"
                                style={{ width: "24px", height: "24px", cursor: "pointer" }}
                            >
                                <path
                                    d="M9.049 2.927c.3-.921 1.603-.921 1.902 0l1.07 3.292a1 1 0 00.95.69h3.462c.969 0 1.371 1.24.588 1.81l-2.8 2.034a1 1 0 00-.364 1.118l1.07 3.292c.3.921-.755 1.688-1.54 1.118l-2.8-2.034a1 1 0 00-1.175 0l-2.8 2.034c-.784.57-1.838-.197-1.539-1.118l1.07-3.292a1 1 0 00-.364-1.118L2.98 8.72c-.783-.57-.38-1.81.588-1.81h3.461a1 1 0 00.951-.69l1.07-3.292z"
                                />
                            </svg>
                        </span>
                        <span>{movie.averageRating?.toFixed(1)}</span>
                    </div>
                    <p><span className="bolded">Duration:</span> {movie.duration} minutes</p>
                </div>

                <p><span className="bolded">Genre:</span> {movie.genreName}</p>
                <p><span className="bolded">User-Creator:</span> {movie.applicationUserUserName}</p>
                <div>
                    <p><span className="bolded">Information</span></p>
                    <p>{movie.description}</p>
                </div>
                <div className="button-div">
                    <span><span className="bolded">Release date:</span> {formatDetailsDate(movie.releaseDate)}</span>
                    <button onClick={() => { navigate(-1) }}>Back</button>
                </div>
                {(movie.applicationUserUserName === username || username === 'admin') &&
                    <div className="edit-delete-buttons mt-2">
                        <button className="btn btn-info" onClick={() => navigate(pathToUrl(Paths.UpdateMovie, { movieId }))}>
                            <i className="bi bi-pencil-fill"></i> Edit
                        </button>
                        <button className="btn btn-danger mx-2" onClick={deleteMovie}>
                            <i className="bi bi-trash-fill"></i> Delete
                        </button>
                    </div>}
            </div>

        </div>
    );
}