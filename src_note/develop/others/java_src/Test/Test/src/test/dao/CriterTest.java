package test.dao;

import static org.apache.commons.dbutils.DbUtils.loadDriver;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.List;
import org.hibernate.Criteria;
import org.hibernate.Query;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;
import org.hibernate.criterion.Restrictions;
import test.entity.District;
import test.util.HibernateUtil;

public class CriterTest{
  static{
    loadDriver("oracle.jdbc.driver.OracleDriver");
  }

  static Connection con = null;

  public static Connection openConnection(){
    try{
      con = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:orcl","Scott","Scott");
    }catch(SQLException e){
      e.printStackTrace();
    }
    return con;
  }

  public static void closeCon(){
    if(null != con){
      try{
        con.close();
        con = null;
      }catch(SQLException e){
        e.printStackTrace();
      }
    }
  }

  public static Session getSession(){
    return HibernateUtil.getCurrentSession();
  }
  
  
  public static void queryDistricts(){
    Configuration config = new Configuration().configure();
    SessionFactory sf = config.buildSessionFactory();
    Session session = sf.openSession();
    String hql = "from District";
    Query query = session.createQuery(hql);
    @SuppressWarnings("unchecked")
    List<District> list = (List<District>) query.list();
    System.out.println("城区ID" + "\t" + "城区名称");
    for(District district : list){
      System.out.println(district.getId() + "\t" + district.getName());
    }
    District ds = (District) session.get(District.class,new Integer(3));
    System.out.println("城区ID" + "\t" + "城区名称");
    System.out.println(ds.getId() + "\t" + ds.getName());
    if(null != session){
      session.close();
      session = null;
    }
    /* return list; */
  }

  public static Integer queryCount(){
    Integer count = 1;
    return count;
  }

  @SuppressWarnings("unchecked")
  public static void query(){
    Session session = getSession();
    Query query = session.createQuery("from District");
    Integer countSize = 4;
    Integer pageIndex = 1;
    query.setFirstResult((pageIndex - 1) * countSize);
    query.setMaxResults(countSize);
    List<District> list = (List<District>) query.list();
    for(District d : list){
      System.out.println(d.getName() + "\t" + d.getId());
    }
  }

  @SuppressWarnings("unchecked")
  public static void queryCriteria1(){
    Session session = getSession();
    Criteria criteria = session.createCriteria(District.class);
    List<District> list = (List<District>) criteria.list();
    for(District district : list){
      System.out.println(district.getId() + "\t" + district.getName());
    }
  }

  /**
   *
   */
  @SuppressWarnings("unchecked")
  public static void queryTest(){
    Session session = getSession();
    Criteria criteria = session.createCriteria(District.class);
    //criteria.add(Restrictions.ge("id",3));
    criteria.add(Restrictions.between("id",5,10));
    List<District> list = (List<District>) criteria.list();
    for(District district : list){
      System.out.println(district.getId() + "\t" + district.getName());
    }
  } 

  public static void main(String ... args){
    // queryDistricts();
    // query();
    // queryCriteria1();
    queryTest();
  }
}