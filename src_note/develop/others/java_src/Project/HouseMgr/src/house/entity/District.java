package house.entity;
import java.util.HashSet;
import java.util.Set;

public class District{
  public District(){}
  private Integer id;
  private String name;
  private Set<Street> streets = new HashSet<>();

  public Integer getId(){
    return id;
  }

  public void setId(Integer id){
    this.id = id;
  }

  public String getName(){
    return name;
  }

  public void setName(String name){
    this.name = name;
  }
  public Set<Street> getStreets(){
    return streets;
  }

  public void setStreets(Set<Street> streets){
    this.streets = streets;
  }
  
}
