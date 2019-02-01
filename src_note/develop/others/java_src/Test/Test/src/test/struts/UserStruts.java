package test.struts;

import com.opensymphony.xwork2.ActionSupport;

public class UserStruts extends ActionSupport{
  /**
   * 
   */
  private static final long serialVersionUID = 1L;

/*
 * public String name = ""; public String pwd = "";
 */
  private User user;
 
  @Override
  public String execute() throws Exception{
    if("admin".equals(user.getName()) && "admin".equals(user.getPwd())){
      user.setName("hello?" + user.getName());
      return "success";
    }else{
      user.setName("error!");
      return "error";
    }
  }

  /**
   * @return the user
   */
  public User getUser(){
    return user;
  }

  /**
   * @param user the user to set
   */
  public void setUser(User user){
    this.user = user;
  }

}
