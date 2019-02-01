package movie.entity;
import java.util.HashSet;
import java.util.Set;

/**
 * Movietype entity. @author MyEclipse Persistence Tools
 */

@SuppressWarnings("serial")
public class MovieType implements java.io.Serializable{

  // Fields

  private Integer typeid;

  private String typename;

  private Set<Movie> movies = new HashSet<Movie>();

  // Constructors

  /** default constructor */
  public MovieType(){}

  /** full constructor */
  public MovieType(String typename,Set<Movie> movies){
    this.typename = typename;
    this.movies = movies;
  }

  // Property accessors

  public Integer getTypeid(){
    return this.typeid;
  }

  public void setTypeid(Integer typeid){
    this.typeid = typeid;
  }

  public String getTypename(){
    return this.typename;
  }

  public void setTypename(String typename){
    this.typename = typename;
  }

  public Set<Movie> getMovies(){
    return this.movies;
  }

  public void setMovies(Set<Movie> movies){
    this.movies = movies;
  }

}