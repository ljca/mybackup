package exam.leave.entity;

import java.util.Date;

public class LeaveRecords{

  private Integer id;
  
  private String name;
  
  private Date time;

  private String reason;

  /**
   * @return the id
   */
  public Integer getId(){
    return id;
  }

  /**
   * @param id the id to set
   */
  public void setId(Integer id){
    this.id = id;
  }

  /**
   * @return the name
   */
  public String getName(){
    return name;
  }

  /**
   * @param name the name to set
   */
  public void setName(String name){
    this.name = name;
  }

  /**
   * @return the time
   */
  public Date getTime(){
    return time;
  }

  /**
   * @param time the time to set
   */
  public void setTime(Date time){
    this.time = time;
  }

  /**
   * @return the reason
   */
  public String getReason(){
    return reason;
  }

  /**
   * @param reason the reason to set
   */
  public void setReason(String reason){
    this.reason = reason;
  }
  
}
