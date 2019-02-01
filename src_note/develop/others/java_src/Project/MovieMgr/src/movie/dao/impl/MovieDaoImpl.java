package movie.dao.impl;

import java.util.List;

import org.hibernate.Query;
import org.hibernate.Session;
import movie.dao.IMovieDao;
import movie.util.HibernateSessionFactory;

public class MovieDaoImpl implements IMovieDao{

  @Override
  public List<?> queryAllMovies(){
    List<?> list = null;
    Session session = HibernateSessionFactory.getSession();
    Query query = session.createQuery("from MovieType m inner join fetch m.movies");
    list = query.list();
    if(null != session){
      HibernateSessionFactory.closeSession();
    }
    return list;
  }

  @Override
  public List<?> queryMoviesById(){
    // TODO Auto-generated method stub
    return null;
  }

}