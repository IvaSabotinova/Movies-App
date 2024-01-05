import { useState, useEffect } from 'react';

import './MovieCreate.css';

import * as genreService from '../../services/genreService';

export default function MovieCreate() {
  const [genres, setGenres] = useState([]);

  useEffect(() => {
    genreService.getAllGenres()
      .then(setGenres)
  }, []);


  return (
    <div className="container mt-5 p-5">
      <h3 className="offset-2 px-2 text-info">Add Movie</h3>
      <form method="post" encType="multipart/form-data">
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
            />
            <label className="mt-2" htmlFor="genre">Genre</label>
            <select className="form-control mt-1"
              id="genre"
              name="genre"
              required
            //  value={formValues.type}
            //  onChange={changeHandler}
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
              nam="description"
              className="form-control mt-1"
              placeholder="Enter Description"
            ></textarea>
            <label className="mt-2" htmlFor="duration">Duration</label>
            <input
              id="duration"
              name="duration"
              type="number"
              className="form-control mt-1"
              placeholder="Enter Duration"
            />
            <label className="mt-2" htmlFor="release-date">Release Date</label>
            <input
              id="release-date"
              name="release-date"
              type="date"
              className="form-control mt-1"
              placeholder="Enter Release Date"
            />
            <label className="mt-2" htmlFor="image">Add Image</label>
            <input id="image" name="image" type="file" className="form-control mt-1" />
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