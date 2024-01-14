import { useState } from 'react';

import './StarRating.css';

import ToastNotify from '../../toast/ToastNotify';
import * as ratingService from '../../services/ratingService';

import Star from './Star';

export default function StarRating({
    movieId,
    title,
    userId,
    onRatingUpdate
}) {
    const [rating, setRating] = useState(0);
    const [tempRating, setTempRating] = useState(0);

    const handleRating = async () => {
        if (!userId) {
            ToastNotify("Please log in first before rating!", "warning")
        }
        else {
            try {

                const result = await ratingService.getRating(userId, movieId);
                if (result.isSuccess) {

                    if (result.result) {
                        const rating = await ratingService.updateRating(userId, movieId, tempRating);
                        ToastNotify(`Your vote for ${title.toUpperCase()} was updated successfully!`, "success")
                    } else {

                        const rating = await ratingService.createRating(userId, movieId, tempRating);
                        ToastNotify(`You have successfully voted for ${title.toUpperCase()}!`, "success")
                    }
                    onRatingUpdate();
                    setRating(tempRating);

                } else {
                    ToastNotify("Oops! Something went wrong! Please try again!", "error")
                }

            } catch (err) {
                ToastNotify(err, "error")
                console.error(err);
            }

        }
    }

    return (
        <div className="star-rating-container">
            <div className="all-stars-container">
                {Array.from({ length: 10 }, (_, index) => (
                    <Star
                        key={index}                       
                        onRate={handleRating}
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