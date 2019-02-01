package house.pojo;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;

@Entity
public class Street{
  public Street(){}
  @Id
  @GeneratedValue
  private Integer id;

  private String name;

  //private Integer districtId;

  private District district;

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

  public District getDistrict(){
    return district;
  }

  public void setDistrict(District district){
    this.district = district;
  }

}
