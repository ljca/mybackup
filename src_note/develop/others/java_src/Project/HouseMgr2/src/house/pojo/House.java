package house.pojo;

import java.util.Date;

public class House{
  public House(){}

/*
 * ID TITLE DESCRIPTION PRICE PUBDATE AREA CONTACT USER_ID TYPE_ID STREET_ID
 * ���� ------- ----- NUMBER(4) VARCHAR2(50) VARCHAR2(255) NUMBER(6) DATE
 * NUMBER(4) VARCHAR2(100) NUMBER(4) NUMBER(4) NUMBER(4)
 */

  private Integer id;

  private String title;

  private String description;

  private Integer price;

  private Date pubDate;

  private String contact;

  private Integer area;

  private Users users;
  
  private Types types;
  
  private Street streets;
  
  public Integer getId(){
    return id;
  }

  public void setId(Integer id){
    this.id = id;
  }

  public String getTitle(){
    return title;
  }

  public void setTitle(String title){
    this.title = title;
  }

  public String getDescription(){
    return description;
  }

  public void setDescription(String description){
    this.description = description;
  }

  public Integer getPrice(){
    return price;
  }

  public void setPrice(Integer price){
    this.price = price;
  }

  public Date getPubDate(){
    return pubDate;
  }

  public void setPubDate(Date pubDate){
    this.pubDate = pubDate;
  }

  public String getContact(){
    return contact;
  }

  public void setContact(String contact){
    this.contact = contact;
  }

  public Integer getArea(){
    return area;
  }

  public void setArea(Integer area){
    this.area = area;
  }

  /**
   * @return the users
   */
  public Users getUsers(){
    return users;
  }

  /**
   * @param users the users to set
   */
  public void setUsers(Users users){
    this.users = users;
  }

  /**
   * @return the types
   */
  public Types getTypes(){
    return types;
  }

  /**
   * @param types the types to set
   */
  public void setTypes(Types types){
    this.types = types;
  }

  /**
   * @return the streets
   */
  public Street getStreets(){
    return streets;
  }

  /**
   * @param streets the streets to set
   */
  public void setStreets(Street streets){
    this.streets = streets;
  }

}