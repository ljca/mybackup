package test.struts;
import com.opensymphony.xwork2.Action;

public class HelloWorldAction implements Action{

  private String name;
  
  private String message;
  
  @Override
  public String execute() throws Exception{
    this.setMessage("Hello,"+this.getName()+"!");
    return "success";
  }

  /**
   * @return the name
   */
  public String getName(){
    return name;
  }

  /**
   * @param name the name to set
   */
  public void setName(String name){
    this.name = name;
  }

  /**
   * @return the message
   */
  public String getMessage(){
    return message;
  }

  /**
   * @param message the message to set
   */
  public void setMessage(String message){
    this.message = message;
  }

}