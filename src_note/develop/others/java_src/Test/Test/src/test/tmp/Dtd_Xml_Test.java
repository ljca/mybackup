package test.tmp;

import java.io.File;
import java.util.List;
import org.dom4j.Document;
import org.dom4j.DocumentException;
import org.dom4j.Element;
import org.dom4j.io.SAXReader;
import test.entity.District;

public class Dtd_Xml_Test extends ReflectDao<District> implements Dao{

  public Dtd_Xml_Test(){}
  
  public Dtd_Xml_Test(String name){}
  
  @Override
  public List<District> queryList(){
    return super.queryList("from District");
  }


  /**
   * 
   */
  @SuppressWarnings("unchecked")
  public static void xmlTmp(){
    /*
     * for(District district : new TmpDaoImpl().queryList()){
     * System.out.println(district.getName() + "\t" +
     * district.getClass().toString() + "\t" + district.getId()); }
     */
    String tmp = System.getProperty("user.dir");
    if(null != tmp){
      tmp += "\\src\\test\\tmp\\dtd-xml\\test.xml";
    }
    SAXReader reader = new SAXReader();
    Document document = null;
    try{
      document = reader.read(new File(tmp));
      // document.getRootElement().elements();//.element("stu");
      List<Element> elements = (document.getRootElement()).elements();
      for(Element le : elements){
        System.out.print(le.getName()+":");
        if(null != le){
          List<Element> tl = le.elements();
          for(Element element2 : tl){
            System.out.print(element2.getText() + "  ");
          }
        }
        System.out.println();
      }

      // List<Element> ele = element.elements();
      /*
       * if(null != element){ for(Element element2 : ele){
       * System.out.print(element2.getText() + "  "); } }
       */
      if(null != document){
        System.out.println();
      }
    }catch(DocumentException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }
  }

  /**
   * 
   */
  public void tmp(){
    String tmp1 = System.getProperty("user.home");
    String tmp2 = System.getProperty("user.name");
    String tmp3 = System.getProperty("java.version");
    String tmp4 = System.getProperty("java.home");
    String tmp6 = System.getProperty("os.name");
    String tmp7 = System.getProperty("os.arch");
    String tmp8 = System.getProperty("os.version");
    String tmp5 = System.getProperty("java.class.path");
    String tmp9 = System.getProperty("java.ext.dirs");
    System.out.println(tmp1); System.out.println(tmp2);System.out.println(tmp3);System.out.println(tmp4);
    System.out.println(tmp5);System.out.println(tmp6);System.out.println(tmp7);System.out.println(tmp8);
    System.out.println(tmp9);
  }

  public static void main(String[] args){
    xmlTmp();
  }
  
}
