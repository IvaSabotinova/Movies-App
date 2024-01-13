import { useState } from 'react';

import './StarRating.css';

import Star from './Star';

export default function StarRating({
    movieId,
    userId
}) {
    const [rating, setRating] = useState(0);
    const [tempRating, setTempRating] = useState(0);

    

    return (
        <div className="star-rating-container">
            <div className="all-stars-container">
                {Array.from({ length: 10 }, (_, index) => (
                    <Star
                        key={index}
                        onRate={() => setRating(index + 1)}
                        isFull={tempRating ? tempRating >= index + 1 : rating >= index + 1}
                        onHoverIn={() => setTempRating(index + 1)}
                        onHoverOut={() => setTempRating(0)}
                    />
                ))}
            </div>
            <p className="rating-number">{tempRating || rating || ''}</p>
        </div>
    );
}