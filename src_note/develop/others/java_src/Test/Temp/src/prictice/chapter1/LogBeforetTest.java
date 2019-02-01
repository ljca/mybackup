package prictice.chapter1;

import java.lang.reflect.Method;
import org.apache.log4j.Logger;
import org.springframework.aop.MethodBeforeAdvice;

public class LogBeforetTest implements MethodBeforeAdvice{
private Logger logger = Logger.getLogger(this.getClass());
  @Override
  public void before(Method arg0,Object[] arg1,Object arg2) throws Throwable{
    // TODO Auto-generated method stub
    logger.info("调用"+arg2+"的"+arg0.getName()+"的方法！");
  }

}
