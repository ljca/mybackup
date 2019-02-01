package prictice.chapter1;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class User{
public void saveUsr(){
  System.out.println("Save User:Tom!");
}

public static void main(String[] args){
  ApplicationContext ctx = new ClassPathXmlApplicationContext("applicationContext.xml");
  if(null != ctx){
    User user = (User)ctx.getBean("user");
    if(null != user){
      user.saveUsr();
    }
  }
}

}
