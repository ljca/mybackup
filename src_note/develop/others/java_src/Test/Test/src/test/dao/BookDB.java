package test.dao;

import java.util.Date;

public class BookDB{
  
  /*
   * 
   * 
   * +----------+-------------+------+-----+---------+----------------+
| Field    | Type        | Null | Key | Default | Extra          |
+----------+-------------+------+-----+---------+----------------+
| b_id     | int(10)     | NO   | PRI | NULL    | auto_increment |
| b_name   | varchar(40) | NO   |     | NULL    |                |
| b_author | varchar(40) | NO   |     | NULL    |                |
| b_time   | date        | NO   |     | NULL    |                |
| b_type   | varchar(40) | NO   |     | NULL    |                |
+----------+-------------+------+-----+---------+----------------+
   */
  private Integer bId;
  
  private String bName;
  
  private String bAuthor;
  
  private Date bTime;
  
  private String bType;

  /**
   * @return the bId
   */
  public Integer getbId(){
    return bId;
  }

  /**
   * @param bId the bId to set
   */
  public void setbId(Integer bId){
    this.bId = bId;
  }

  /**
   * @return the bName
   */
  public String getbName(){
    return bName;
  }

  /**
   * @param bName the bName to set
   */
  public void setbName(String bName){
    this.bName = bName;
  }

  /**
   * @return the bAuthor
   */
  public String getbAuthor(){
    return bAuthor;
  }

  /**
   * @param bAuthor the bAuthor to set
   */
  public void setbAuthor(String bAuthor){
    this.bAuthor = bAuthor;
  }

  /**
   * @return the bTime
   */
  public Date getbTime(){
    return bTime;
  }

  /**
   * @param bTime the bTime to set
   */
  public void setbTime(Date bTime){
    this.bTime = bTime;
  }

  /**
   * @return the bType
   */
  public String getbType(){
    return bType;
  }

  /**
   * @param bType the bType to set
   */
  public void setbType(String bType){
    this.bType = bType;
  }
  
}
