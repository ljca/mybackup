package test.struts;

import java.util.ArrayList;
import java.util.List;
import org.apache.log4j.Logger;
import com.opensymphony.xwork2.ActionSupport;

public class TestOGNLAction extends ActionSupport{
  
  /**
   * 
   */
  private static final long serialVersionUID = 1L;
  private final Logger logger = Logger.getLogger(this.getClass());
  List list = new ArrayList();

  /**
   * @return the list
   */
  public List getList(){
    return list;
  }

  /**
   * @param list the list to set
   */
  public void setList(List list){
    this.list = list;
  }

  @Override
  public String execute() throws Exception{
    logger.info("");
    list.add("Java");
    list.add("C#");
    list.add("Jsp_Servlet");
    return "success";
  }


}
