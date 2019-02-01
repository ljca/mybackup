package accp.test.entity;

import java.util.Date;

public class Attence{
  /*
   * ID EMPNAME DEPT CHKDATE STATUS
   */

  private int id; // 员工编号

  private String empName; // 员工姓名

  private String dept; // 所属部门

  private Date chkDate; // 考勤日期

  private String status; // 考勤状态

  public int getId(){
    return id;
  }

  public void setId(int id){
    this.id = id;
  }

  public String getEmpName(){
    return empName;
  }

  public void setEmpName(String empName){
    this.empName = empName;
  }

  public String getDept(){
    return dept;
  }

  public void setDept(String dept){
    this.dept = dept;
  }

  public Date getChkDate(){
    return chkDate;
  }

  public void setChkDate(Date chkDate){
    this.chkDate = chkDate;
  }

  public String getStatus(){
    return status;
  }

  public void setStatus(String status){
    this.status = status;
  }

}
