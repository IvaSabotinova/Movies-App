import { useState, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';

import * as genreService from '../../services/genreService';
import * as movieService from '../../services/movieService';
import Paths from '../../constants/Paths';
import { pathToUrl } from '../../utils/pathsUtil';

const movieEmptyState = {
  title: '',
  genreId: '',
  description: '',
  duration: '',
  releaseDate: '',
  imageUrl: ''
}

export default function MovieCreate() {
  const [genres, setGenres] = useState([]);
  const [movie, setMovie] = useState(movieEmptyState);
  const navigate = useNavigate();

  useEffect(() => {
    genreService.getAllGenres()
      .then(setGenres)
  }, []);

  const changeHandler = (e) => {
    let value = '';

    switch (e.target.type) {
      case 'number': value = Number(e.target.value); break;
      case 'checkbox': value = e.target.checked; break;
      default: value = e.target.value; break
    }
    setMovie(state => ({ ...state, [e.target.name]: value }))
  }

  const submitHandler = async (e) => {
    e.preventDefault();
    const newMovie = await movieService.createMovie(movie);
    console.log(newMovie)
    navigate(pathToUrl(Paths.MovieDetails, { movieId: newMovie.result.id }))
  }

  return (
    <div className="container mt-5 p-5">
      <h3 className="offset-2 px-2 text-info">Add Movie</h3>
      <form method="post" encType="multipart/form-data" onSubmit={submitHandler}>
        <div className="row mt-1">
          <div className="col-md-5 offset-2 text-info">
            <label htmlFor="title">Title</label>
            <input
              id="title"
              type="text"
              name="title"
              className="form-control mt-1"
              placeholder="Enter Title"
              required
              value={movie.title}
              onChange={changeHandler}
            />
            <label className="mt-2" htmlFor="genreId">Genre</label>
            <select className="form-control mt-1"
              id="genreId"
              name="genreId"
              required
              value={movie.genreId}
              onChange={changeHandler}
            //  onBlur={validateType}
            >
              <option value="" disabled="">Choose Genre</option>
              {genres.map(genre => (
                <option key={genre.value} value={genre.value}>{genre.text}</option>
              ))}
            </select>
            <label className="mt-2" htmlFor="description">Description</label>
            <textarea
              id="description"
              name="description"
              className="form-control mt-1"
              placeholder="Enter Description"
              value={movie.description}
              onChange={changeHandler}
            ></textarea>
            <label className="mt-2" htmlFor="duration">Duration</label>
            <input
              id="duration"
              name="duration"
              type="number"
              className="form-control mt-1"
              placeholder="Enter Duration"
              value={movie.duration}
              onChange={changeHandler}
            />
            <label className="mt-2" htmlFor="releaseDate">Release Date</label>
            <input
              id="releaseDate"
              name="releaseDate"
              type="date"
              className="form-control mt-1"
              placeholder="Enter Release Date"
              value={movie.releaseDate}
              onChange={changeHandler}
            />
            <label className="mt-2" htmlFor="imageUrl">Add Image</label>
            {/* <input
              id="ImageUrl"
              name="ImageUrl"
              type="file"
              className="form-control mt-1"
              value={movie.ImageUrl}
              onChange={changeHandler}
            /> */}
            <input
              id="imageUrl"
              name="imageUrl"
              type="text"
              className="form-control mt-1"
              value={movie.imageUrl}
              onChange={changeHandler}
            />
            <div className="text-center">
              <button
                type="submit"
                style={{ width: "50%" }}
                className="btn btn-info mt-2"
              >
                Submit
              </button>
            </div>
          </div>
          <div className="col-md-5 text-center">
            <img
              src="https://via.placeholder.com/150"
              style={{ width: "100%", borderRadius: "30px" }}
              alt=""
            />
          </div>
        </div>
      </form>
    </div>
  );
}