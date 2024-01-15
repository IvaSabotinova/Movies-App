import { useState, useEffect, useContext } from 'react';

import './WatchList.css';

import * as watchListService from '../../services/watchListService';
import AuthContext from '../../contexts/AuthContext';
import WatchListSingleMovie from './WatchListSingleMovie';


export default function WatchList() {       
    const [watchList, setWatchList] = useState([]);  
    const { userId } = useContext(AuthContext);

    useEffect(() => {
        watchListService.getWatchList(userId)
            .then((res)=>setWatchList(res.result))
            .catch((err) => console.log(err))
    }, [userId]);

    return (
        <div className="watch-list">
            <h1>My Watch List</h1>
            <div className="all">
                {watchList.map(movie => <WatchListSingleMovie key={movie.id} {...movie}/>)}         
            </div>
        </div>
    );
}