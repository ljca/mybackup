package easybuy.entity;

import java.util.Date;

/**
 * 新闻表
 * 
 * @author YL_HH_GG
 * 
 */
public class News{
  /*
   * en_id 编号 自动编号（标识列），从1开始，主键 en_title 标题 en_content 内容 en_create_time 录入日期
   */

  private int enId;

  private String enTitle;

  private String enContent;

  private Date enCreateTime;

  public int getEnId(){
    return enId;
  }

  public void setEnId(int enId){
    this.enId = enId;
  }

  public String getEnTitle(){
    return enTitle;
  }

  public void setEnTitle(String enTitle){
    this.enTitle = enTitle;
  }

  public String getEnContent(){
    return enContent;
  }

  public void setEnContent(String enContent){
    this.enContent = enContent;
  }

  public Date getEnCreateTime(){
    return enCreateTime;
  }

  public void setEnCreateTime(Date enCreateTime){
    this.enCreateTime = enCreateTime;
  }

}
