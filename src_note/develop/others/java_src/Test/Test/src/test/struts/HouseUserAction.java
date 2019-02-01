package test.struts;

import com.opensymphony.xwork2.ActionSupport;

public class HouseUserAction extends ActionSupport{
  
  private String login(){
    // TODO Auto-generated method stub
    
    
    return "login";
  }
  
  public String listUser(){
    
    return "user";
  }

}
