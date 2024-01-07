import { useState, useEffect, useContext } from 'react';
import { useNavigate, useParams } from 'react-router-dom';

import * as genreService from '../../services/genreService';
import * as movieService from '../../services/movieService';
import { formatInputDate } from '../../utils/dateUtil';
import ToastNotify from '../../toast/ToastNotify';
import MovieContext from '../../contexts/MovieContext';

const movieEmptyState = {
  title: '',
  genreId: '',
  description: '',
  duration: '',
  releaseDate: '',
  imageUrl: ''
}
export default function MovieCreateUpdate() {
  const [genres, setGenres] = useState([]);
  const [movie, setMovie] = useState(movieEmptyState);
  const {createMovieHandler, updateMovieHandler} = useContext(MovieContext)
  const [imageToDisplay, setImageToDisplay] = useState("");
  const { movieId } = useParams();
  const navigate = useNavigate();

  useEffect(() => {
    genreService.getAllGenres()
      .then(setGenres)
  }, []);

  useEffect(() => {
    if (movieId) {
      movieService.getMovieDetails(movieId)
        .then((res) => {
          setMovie({
            title: res.result.title,
            genreId: genres.find(x => x.text === res.result.genreName)?.value || '',
            description: res.result.description,
            duration: res.result.duration,
            releaseDate: formatInputDate(res.result.releaseDate),
            imageUrl: res.result.imageUrl
          });
          setImageToDisplay(res.result.imageUrl)
        })
    }else {
      setMovie(movieEmptyState);
      setImageToDisplay("");
    }
  }, [movieId, genres])

  const changeHandler = (e) => {
    let value = '';
    switch (e.target.type) {
      case 'number': value = Number(e.target.value); break;
      case 'checkbox': value = e.target.checked; break;
      default: value = e.target.value; break
    }
    setMovie(state => ({ ...state, [e.target.name]: value }))
  }

  const changeFileHandler = (e) => {
    const file = e.target.files && e.target.files[0];
    if (file) {
      const fileType = file.type.split('/')[1];
      const validImageExtensions = ["jpeg", "jpg", "png"];
      const isImageExtensionAllowed = validImageExtensions.includes(fileType);

      if (file.size > 5 * 1000 * 1024) {
        ToastNotify("File Must be less then 5 MB", "error");
        return;
      } else if (!isImageExtensionAllowed) {
        ToastNotify("File must have jpeg, jpg or png extension", "error");
        return;
      }

      const reader = new FileReader();
      reader.readAsDataURL(file)
      reader.onload = (e) => {
        const imageUrl = e.target?.result;
        setImageToDisplay(imageUrl);
        setMovie((state) => ({ ...state, imageUrl: imageUrl }));
      }
    }
  }

  const submitHandler = async (e) => {
    e.preventDefault();
    if (movieId) {
      updateMovieHandler(movieId, movie);     
    }
    else {
      createMovieHandler(movie);    
    }

  }

  return (
    <div className="container mt-5 p-5">
      <h3 className="offset-2 px-2 text-info">{movieId ? "Edit Movie" : "Add Movie"}</h3>
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
            <input
              id="imageUrl"
              name="imageUrl"
              type="file"
              className="form-control mt-1"
              // value={movie.imageUrl}
              onChange={changeFileHandler}
            />
          
            <div className="row">
              <div className="col-6">
                <button type="submit" className="btn btn-info mt-2 form-control">
                  Submit
                </button>
              </div>
              <div className="col-6">
                <a onClick={() => navigate(-1)} className='btn btn-secondary form-control mt-2'>
                  Back To Previous Page
                </a>
              </div>
            </div>
          </div>
          <div className="col-md-5 text-center">
            <img
              src={imageToDisplay !== "" ? imageToDisplay : "https://via.placeholder.com/150"}
              style={{ width: "80%", borderRadius: "30px", height: "500px" }}
              alt=""
            />
          </div>
        </div>
      </form>
    </div>
  );
}