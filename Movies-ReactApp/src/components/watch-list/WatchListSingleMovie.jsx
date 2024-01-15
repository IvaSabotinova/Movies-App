import { useNavigate } from 'react-router-dom';
import './WatchList.css';

import { pathToUrl } from '../../utils/pathsUtil';
import Paths from '../../constants/Paths';

export default function WatchListSingleMovie({
    id,
    title,
    averageRating,
    imageUrl
}) {
    const navigate = useNavigate();
    return (
        <div className="single-movie">
            <div className="watch-image">
                <img src={imageUrl} alt="movie-image" />
            </div>
            <div className="info">
                <h4>Title: {title}</h4>
                <div className="line"></div>
                <div className="ratingInfo">Rating: {averageRating?.toFixed(1)}</div>
                <div className="line"></div>
                <div className="watchList-button" >
                    <button
                        className="watchList-details btn btn-success"
                        onClick={() => navigate(pathToUrl(Paths.MovieDetails, { movieId: id}))}>Details</button>
                    <button className="watchList-remove">Remove</button>
                </div>
            </div>
        </div>
    );
}