package test.entity;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "users", schema = "tmp")
public class Users{
  public Users(){}

  private Integer id;

  private String name;

  private String userName;

  private String passWord;

  private String telePhone;

  private String isAdmin;

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

  @Column(name="username")
  public String getUserName(){
    return userName;
  }

  public void setUserName(String userName){
    this.userName = userName;
  }

  @Column(name="password")
  public String getPassWord(){
    return passWord;
  }

  public void setPassWord(String passWord){
    this.passWord = passWord;
  }

  @Column(name="telephone")
  public String getTelePhone(){
    return telePhone;
  }

  public void setTelePhone(String telePhone){
    this.telePhone = telePhone;
  }

  @Column(name="isadmin")
  public String getIsAdmin(){
    return isAdmin;
  }

  public void setIsAdmin(String isAdmin){
    this.isAdmin = isAdmin;
  }

}
