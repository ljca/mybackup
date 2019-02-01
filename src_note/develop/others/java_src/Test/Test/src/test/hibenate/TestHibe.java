package test.hibenate;

import java.util.List;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.AnnotationConfiguration;
import test.entity.District;
import test.util.HibernateUtil;

public class TestHibe{

  @SuppressWarnings("unchecked")
  public static void testHibernate(){
    //SessionFactory sf = new AnnotationConfiguration().configure().buildSessionFactory();
    Session session = HibernateUtil.getCurrentSession();//sf.openSession();
    List<District> list = session.createCriteria(District.class).list();
    for(District district : list){
      System.out.println(district.getName() + "\t" + district.getId());
    }
  }
  public static void main(String[] args){
    testHibernate();
  }
}
