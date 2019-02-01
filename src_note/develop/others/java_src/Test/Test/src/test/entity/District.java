package test.entity;
import javax.persistence.*;

@Entity
@Table(schema = "tmp", name = "district")
public class District{
  public District(){}

  private Integer id;

  private String name;

  @Id
  @GeneratedValue(strategy = GenerationType.AUTO)
  public Integer getId(){
    return id;
  }

  public void setId(Integer id){
    this.id = id;
  }

  @Column(name="name")
  public String getName(){
    return name;
  }

  public void setName(String name){
    this.name = name;
  }

}
