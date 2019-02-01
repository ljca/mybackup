package test.entity;

/**
 * 部门表
 * 
 * @author tmp
 * 
 */
public class Dept{
  public Dept(){}

  public Dept(Integer id,String dname,String loc){
    this.deptNo = id;
    this.dName = dname;
    this.loc = loc;
  }

  /*
   * DEPTNO NOT NULL NUMBER(2) DNAME VARCHAR2(14) LOC VARCHAR2(13)
   */
  private Integer deptNo;

  private String dName;

  private String loc;

  /**
   * @return the deptNo
   */
  public Integer getDeptNo(){
    return deptNo;
  }

  /**
   * @param deptNo
   *          the deptNo to set
   */
  public void setDeptNo(Integer deptNo){
    this.deptNo = deptNo;
  }

  /**
   * @return the dName
   */
  public String getdName(){
    return dName;
  }

  /**
   * @param dName
   *          the dName to set
   */
  public void setdName(String dName){
    this.dName = dName;
  }

  /**
   * @return the loc
   */
  public String getLoc(){
    return loc;
  }

  /**
   * @param loc
   *          the loc to set
   */
  public void setLoc(String loc){
    this.loc = loc;
  }

}
