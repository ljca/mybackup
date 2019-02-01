package movie.dao;

import java.util.List;

public interface IMovieDao{
  List<?> queryAllMovies();
  List<?> queryMoviesById();

}
