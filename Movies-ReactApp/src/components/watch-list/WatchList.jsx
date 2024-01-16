import { useState, useEffect, useContext } from 'react';

import './WatchList.css';

import * as watchListService from '../../services/watchListService';
import AuthContext from '../../contexts/AuthContext';
import WatchListItem from './WatchListItem';
import ToastNotify from '../../toast/ToastNotify';


export default function WatchList() {
    const [watchList, setWatchList] = useState([]);
    const { userId } = useContext(AuthContext);

    useEffect(() => {
        watchListService.getWatchList(userId)
            .then((res) => setWatchList(res.result))
            .catch((err) => console.log(err))
    }, [userId]);

    const deleteFromWatchList = async (id, title) => {
        try {
            const hasConfirmed = confirm(`Are you sure you want to remove ${title.toUpperCase()} from your watch list?`)
            if (hasConfirmed) {
                await watchListService.deleteMovieFromWatchList(userId, id);
                setWatchList(state => (state.filter(x => x.id !== id)));
                ToastNotify(`${title.toUpperCase()} successfully removed from watch list!`, "success");
            }
        } catch (err) {
            console.log(err);
            ToastNotify("Oops! A problem occurred! Try again!", "error");
        }


    }

    return (
        <div className="watch-list">
            <h1>My Watch List</h1>
            <div className="all">
                {watchList.length === 0
                    ? <div className="centered-para">
                        <p className="watchList-no-movies">You have no movies in your watch list!</p>
                    </div>
                    : watchList.map(movie => <WatchListItem key={movie.id}
                        {...movie}
                        handleDelete={deleteFromWatchList}
                    />)}
            </div>
        </div>
    );
}