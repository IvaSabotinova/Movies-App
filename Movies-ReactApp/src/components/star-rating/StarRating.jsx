

import './StarRating.css';

export default function StarRating() {
    return (
        <div>
            <div style={{ marginTop: '100px' }}>
                {Array.from({ length: 10 }, (_, index) => (
                    <span>Star{index + 1} </span>
                ))}
            </div>
            <p>10</p>
        </div>
    );
}