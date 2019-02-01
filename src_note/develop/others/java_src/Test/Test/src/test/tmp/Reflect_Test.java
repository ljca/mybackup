package test.tmp;
import java.lang.reflect.*;

public class Reflect_Test{
  public Reflect_Test(){}

  @SuppressWarnings("rawtypes")
  // static Class clasz = null;
/*
 * static{ try{ clasz = Class.forName("test.tmp.Dtd_Xml_Test");
 * }catch(ClassNotFoundException e){ // TODO Auto-generated catch block
 * e.printStackTrace(); } }
 */
  public static Class getClasz(Class classs){
    if(null != classs){
      return classs;
    }
    try{
      throw new ClassNotFoundException();
    }catch(ClassNotFoundException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }
    return null;
  }

  @SuppressWarnings("rawtypes")
  public static void main(String[] args){
    Class clasz = getClasz(Dtd_Xml_Test.class);
    if(null != clasz){
      System.out.println("方法");
      for(Method method : clasz.getDeclaredMethods()){
        System.out.println(method.getName());
      }
      System.out.println("构造！");
      for(Constructor constructor : clasz.getConstructors()){
        System.out.print(constructor.getName());System.out.println("");
      }
    }
    try{
      Object object = clasz.newInstance();
      ((Dtd_Xml_Test)object).tmp();
    }catch(InstantiationException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }catch(IllegalAccessException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }
  }

}
