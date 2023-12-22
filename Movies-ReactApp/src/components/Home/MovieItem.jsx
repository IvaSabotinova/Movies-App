
import './Home.css';

export default function MovieItem({
    id,
    title,
    rating,
    imageUrl
}) {

    return (
        <div className="movie-wrapper">
            <div className="image-box">
                <img className="image" src={imageUrl} alt="" />
            </div>
            <div className="movie-info">
                <h3>Title: {title}</h3>
                <p>Rating: {rating}</p>
            </div>
        </div>
    );
}