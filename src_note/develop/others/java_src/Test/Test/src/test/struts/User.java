package test.struts;

public class User{
  private String uname = "xx";
  
  private String pwd = "xx";

  /**
   * @return the name
   */
  public String getName(){
    return uname;
  }

  /**
   * @param name the name to set
   */
  public void setName(String uname){
    this.uname = uname;
  }

  /**
   * @return the pwd
   */
  public String getPwd(){
    return pwd;
  }

  /**
   * @param pwd the pwd to set
   */
  public void setPwd(String pwd){
    this.pwd = pwd;
  }
  
}
