package test.struts;
import org.apache.log4j.Logger;
import com.opensymphony.xwork2.ActionSupport;

public class RegisterAction extends ActionSupport{
  /**
   * 
   */
  private static final long serialVersionUID = -4475975450432097940L;
//private final Logger logger = Logger.getLogger(this.getClass());
  private User user;

  private String repwd;

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

  /**
   * @return the repwd
   */
  public String getRepwd(){
    return repwd;
  }

  /**
   * @param repwd the repwd to set
   */
  public void setRepwd(String repwd){
    this.repwd = repwd;
  }

  @Override
  public String execute() throws Exception{
    // ActionContext ac = ActionContext.getContext();
    // ac.get("");
    // HttpServletRequest request = ServletActionContext.getRequest();
    // HttpServletResponse response = ServletActionContext.getResponse();
    // HttpSession session = request.getSession();
    // return super.execute();
    if(user.getName().equals("tmp") && user.getPwd().equals("tmp")){
      System.out.println(user.getName());
      return "success";
    }
    return "input";
  }

/*
 * @Override public void validate(){ if(null == user.getName() ||
 * user.getName().equals("")){ addFieldError("user.name","用户名不能为空！"); } if(null
 * == user.getPwd() || user.getName().equals("")){
 * addFieldError("user.pwd","用户密码不能为空！"); } } public void validateRegist(){
 * if(user.getName().length() < 6 || user.getName().length() > 15){
 * addFieldError("user.name","长度不能小于六位或者大于十五位！"); } if(user.getPwd().length() <
 * 6){ addFieldError("user.pwd","密码不能小于6位！"); } if(repwd.equals(user.getPwd())){
 * addFieldError("user.pwd","两次输入密码不匹配！"); } }
 */

/*  public String regist(){
    return "input";
  }*/

}
