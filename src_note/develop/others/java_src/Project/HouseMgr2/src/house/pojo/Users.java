package house.pojo;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;

@Entity
public class Users{
  public Users(){}
  public Users(String userName,String pwd){
    this.userName = userName;
    this.passWord = pwd;
  }
  
  public Users(Integer id,String name,String userName,String pwd,String tel,String isadmin){
    this.id = id;
    this.name = name;
    this.userName = userName;
    this.passWord = pwd;
    this.telePhone = tel;
    this.isAdmin = isadmin;
  }
  
  @Id
  @GeneratedValue
  private Integer id;
  
  private String name;
  
  private String userName;
  
  private String passWord;

  private String telePhone;
  
  private String isAdmin;

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

  public String getUserName(){
    return userName;
  }

  public void setUserName(String userName){
    this.userName = userName;
  }

  public String getPassWord(){
    return passWord;
  }

  public void setPassWord(String passWord){
    this.passWord = passWord;
  }

  public String getTelePhone(){
    return telePhone;
  }

  public void setTelePhone(String telePhone){
    this.telePhone = telePhone;
  }

  public String getIsAdmin(){
    return isAdmin;
  }

  public void setIsAdmin(String isAdmin){
    this.isAdmin = isAdmin;
  }

}