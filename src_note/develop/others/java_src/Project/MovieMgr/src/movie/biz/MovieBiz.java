package movie.biz;
import java.util.List;

public interface MovieBiz{
  List<?> queryAllMovies();

  List<?> queryMoviesById();
  
}
