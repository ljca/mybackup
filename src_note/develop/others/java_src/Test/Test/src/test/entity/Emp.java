package test.entity;

import java.util.Date;

/**
 * 员工表
 * @author tmp
 *
 */
public class Emp{
  public Emp(){}
  
  public Emp(Integer empno,String ename,String job,Integer mgr,
      Date hiredte,Float sal,Float comm,Integer deptNo){
    this.empNo = empno;
    this.eName = ename;
    this.job = job;
    this.mgr = mgr;
    this.hireDate = hiredte;
    this.sal = sal;
    this.comm = comm;
    this.deptNo = deptNo;
  }
  
  /*
   * EMPNO NOT NULL NUMBER(4) ENAME VARCHAR2(10) JOB VARCHAR2(9) MGR NUMBER(4)
   * HIREDATE DATE SAL NUMBER(7,2) COMM NUMBER(7,2) DEPTNO NUMBER(2)
   */

  private Integer empNo;
  
  private String eName;
  
  private String job;
  
  private Integer mgr;
  
  private Date hireDate;
  
  private Float sal;
  
  private Float comm;
  
  private Integer deptNo;
  
  private Dept dept;

  /**
   * @return the empNo
   */
  public Integer getEmpNo(){
    return empNo;
  }

  /**
   * @param empNo the empNo to set
   */
  public void setEmpNo(Integer empNo){
    this.empNo = empNo;
  }

  /**
   * @return the eName
   */
  public String geteName(){
    return eName;
  }

  /**
   * @param eName the eName to set
   */
  public void seteName(String eName){
    this.eName = eName;
  }

  /**
   * @return the job
   */
  public String getJob(){
    return job;
  }

  /**
   * @param job the job to set
   */
  public void setJob(String job){
    this.job = job;
  }

  /**
   * @return the mgr
   */
  public Integer getMgr(){
    return mgr;
  }

  /**
   * @param mgr the mgr to set
   */
  public void setMgr(Integer mgr){
    this.mgr = mgr;
  }

  /**
   * @return the hireDate
   */
  public Date getHireDate(){
    return hireDate;
  }

  /**
   * @param hireDate the hireDate to set
   */
  public void setHireDate(Date hireDate){
    this.hireDate = hireDate;
  }

  /**
   * @return the sal
   */
  public Float getSal(){
    return sal;
  }

  /**
   * @param sal the sal to set
   */
  public void setSal(Float sal){
    this.sal = sal;
  }

  /**
   * @return the comm
   */
  public Float getComm(){
    return comm;
  }

  /**
   * @param comm the comm to set
   */
  public void setComm(Float comm){
    this.comm = comm;
  }

  /**
   * @return the deptNo
   */
  public Integer getDeptNo(){
    return deptNo;
  }

  /**
   * @param deptNo the deptNo to set
   */
  public void setDeptNo(Integer deptNo){
    this.deptNo = deptNo;
  }

  /**
   * @return the dept
   */
  public Dept getDept(){
    return dept;
  }

  /**
   * @param dept the dept to set
   */
  public void setDept(Dept dept){
    this.dept = dept;
  }
  
}