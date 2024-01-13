import { useNavigate } from 'react-router-dom';

import './Home.css';

import Paths from '../../constants/Paths';
import { pathToUrl } from '../../utils/pathsUtil';

export default function MovieItem({
    id,
    title,
    averageRating,
    imageUrl
}) {
    const navigate = useNavigate();

    const handleClick = () => {
        navigate(pathToUrl(Paths.MovieDetails, { movieId: id }))
    };

    return (
        <div className="movie-wrapper" onClick={handleClick}>
            <div className="image-box">
                <img className="image" src={imageUrl} alt="" />
            </div>
            <div className="movie-info">
                <h3>Title: {title}</h3>
                <p>Rating: {averageRating}</p>
            </div>
        </div>
    );
}