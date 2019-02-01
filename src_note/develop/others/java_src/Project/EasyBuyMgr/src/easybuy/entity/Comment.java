package easybuy.entity;

import java.util.Date;

/**
 * 留言表
 * 
 * @author YL_HH_GG
 * 
 */
public class Comment{

  /*
   * ec_id 编号 自动编号（标识列），从1开始，主键 ec_reply 回复 ec_content 内容 ec_create_time 创建时间
   * ec_reply_time 回复时间 ec_nick_name 留言用户昵称
   */

  private int ecId;

  private String ecREply;

  private String ecContent;

  private Date ecCreateTime;

  private Date ecReplyTime;

  private String ecNickName;

  public int getEcId(){
    return ecId;
  }

  public void setEcId(int ecId){
    this.ecId = ecId;
  }

  public String getEcREply(){
    return ecREply;
  }

  public void setEcREply(String ecREply){
    this.ecREply = ecREply;
  }

  public String getEcContent(){
    return ecContent;
  }

  public void setEcContent(String ecContent){
    this.ecContent = ecContent;
  }

  public Date getEcCreateTime(){
    return ecCreateTime;
  }

  public void setEcCreateTime(Date ecCreateTime){
    this.ecCreateTime = ecCreateTime;
  }

  public Date getEcReplyTime(){
    return ecReplyTime;
  }

  public void setEcReplyTime(Date ecReplyTime){
    this.ecReplyTime = ecReplyTime;
  }

  public String getEcNickName(){
    return ecNickName;
  }

  public void setEcNickName(String ecNickName){
    this.ecNickName = ecNickName;
  }

}
