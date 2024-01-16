import { useNavigate } from 'react-router-dom';
import './WatchList.css';

import { pathToUrl } from '../../utils/pathsUtil';
import Paths from '../../constants/Paths';

export default function WatchListItem({
    id,
    title,
    averageRating,
    imageUrl,
    handleDelete
}) {

    const navigate = useNavigate();

    const onClickDelete = () => {
        handleDelete(id, title);
    }

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
                        onClick={() => navigate(pathToUrl(Paths.MovieDetails, { movieId: id }))}>Details</button>
                    <button className="watchList-remove" onClick={onClickDelete}>Remove</button>
                </div>
            </div>
        </div>
    );
}