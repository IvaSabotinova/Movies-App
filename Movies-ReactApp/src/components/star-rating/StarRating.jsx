import { useState } from 'react';

import './StarRating.css';

import Star from './Star';

export default function StarRating() {
    const [rating, setRating] = useState(0);
    const [tempRating, setTempRating] = useState(0);

    return (
        <div>
            <div style={{ marginTop: '100px' }}>
                {Array.from({ length: 5 }, (_, index) => (
                    <Star
                        key={index}
                        onRate={() => setRating(index + 1)}
                        isFull={tempRating ? tempRating >= index + 1 : rating >= index + 1}
                        onHoverIn={() => setTempRating(index + 1)}
                        onHoverOut={() => setTempRating(0)}
                    />
                ))}
            </div>
            <p>{tempRating || rating || ''}</p>
        </div>
    );
}