package movie.biz.impl;

import java.util.List;
import movie.biz.MovieBiz;
import movie.dao.impl.MovieDaoImpl;
import movie.entity.Movie;
import movie.entity.MovieType;

public class MovieBizImp extends MovieDaoImpl implements MovieBiz{

  @Override
  public List<?> queryAllMovies(){
    return  super.queryAllMovies();
  }

  @Override
  public List<Movie> queryMoviesById(){
    // TODO Auto-generated method stub
    return null;
  }

  @SuppressWarnings("unchecked")
  public static void main(String[] args){
    List<MovieType> list = (List<MovieType>)new MovieBizImp().queryAllMovies();
    for(MovieType movie : list){
      for(Movie m : movie.getMovies()){
        System.out.println(m.getMdirector() + "\t"+ m.getMprice());
      }
      System.out.println(movie.getTypename());
    }
  }

}