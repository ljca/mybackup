package cn.test.entity;

import java.util.Date;

public class Feeling{
  /*
  f_id
  f_title
  f_content
  f_date
  f_type
  */
  
  private int fid;
  
  private String ftitle;
  
  private String fcontent;
  
  private Date fdate;
  
  private int ftype;

  public int getFid(){
    return fid;
  }

  public void setFid(int fid){
    this.fid = fid;
  }

  public String getFtitle(){
    return ftitle;
  }

  public void setFtitle(String ftitle){
    this.ftitle = ftitle;
  }

  public String getFcontent(){
    return fcontent;
  }

  public void setFcontent(String fcontent){
    this.fcontent = fcontent;
  }

  public Date getFdate(){
    return fdate;
  }

  public void setFdate(Date fdate){
    this.fdate = fdate;
  }

  public int getFtype(){
    return ftype;
  }

  public void setFtype(int ftype){
    this.ftype = ftype;
  }

}
