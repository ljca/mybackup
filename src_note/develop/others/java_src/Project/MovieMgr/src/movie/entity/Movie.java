package movie.entity;

/**
 * Movie entity. @author MyEclipse Persistence Tools
 */

@SuppressWarnings("serial")
public class Movie implements java.io.Serializable{

  // Fields

  private Integer id;

  private MovieType movietype;

  private String mname;

  private String mrole;

  private String mdirector;

  private Double mprice;

  // Constructors

  /** default constructor */
  public Movie(){}

  /** minimal constructor */
  public Movie(MovieType movietype,String mname,String mrole,Double mprice){
    this.movietype = movietype;
    this.mname = mname;
    this.mrole = mrole;
    this.mprice = mprice;
  }

  /** full constructor */
  public Movie(MovieType movietype,String mname,String mrole,String mdirector,Double mprice){
    this.movietype = movietype;
    this.mname = mname;
    this.mrole = mrole;
    this.mdirector = mdirector;
    this.mprice = mprice;
  }

  // Property accessors

  public Integer getId(){
    return this.id;
  }

  public void setId(Integer id){
    this.id = id;
  }

  public MovieType getMovietype(){
    return this.movietype;
  }

  public void setMovietype(MovieType movietype){
    this.movietype = movietype;
  }

  public String getMname(){
    return this.mname;
  }

  public void setMname(String mname){
    this.mname = mname;
  }

  public String getMrole(){
    return this.mrole;
  }

  public void setMrole(String mrole){
    this.mrole = mrole;
  }

  public String getMdirector(){
    return this.mdirector;
  }

  public void setMdirector(String mdirector){
    this.mdirector = mdirector;
  }

  public Double getMprice(){
    return this.mprice;
  }

  public void setMprice(Double mprice){
    this.mprice = mprice;
  }

}