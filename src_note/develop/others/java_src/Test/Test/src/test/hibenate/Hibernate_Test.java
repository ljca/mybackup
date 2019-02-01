package test.hibenate;

import java.util.List;
import org.hibernate.Query;
import org.hibernate.Session;
//import org.hibernate.SessionFactory;
import org.hibernate.Transaction;
//import org.hibernate.cfg.Configuration;
import test.entity.Dept;
import test.util.HibernateUtil;

public class Hibernate_Test{

  public static Session getSession(){
    return HibernateUtil.getCurrentSession();
  }

  public static Query getQuery(String hql){
    return getSession().createQuery(hql);
  }

  /**
   * 主键查询
   */
  public static Dept query(Integer i){
    /**
     * 读取配置文件
     */
    // Configuration conf = new Configuration().configure();
    /**
     * 从配置文件中创建Session工厂对象
     */
    // SessionFactory sf = conf.buildSessionFactory();
    /**
     * 获取Session对象
     */
    // Session session = sf.openSession();// getCurrentSession();
    Session session = getSession();
    /**
     * 根据主键id载入实体对象信息
     */
    // Dept dept = (Dept)session.load(Dept.class,new Integer(20));
    Dept dept = (Dept)session.get(Dept.class,new Integer(i));
    System.out.println("部门编号" + "\t" + "部门名称" + "\t" + "部门其它信息");
    if(null != dept){
      System.out.println(dept.getDeptNo() + "\t" + dept.getdName() + "\t" + dept.getLoc());
    }
    return dept;
  }

  public static void queryAllDept(){
    @SuppressWarnings("unchecked")
    List<Dept> list = getQuery("from Dept d").list();
    System.out.println("部门编号" + "\t" + "部门名称" + "\t" + "部门其它信息");
    if(null != list){
      for(Dept dept : list){
        if(null != dept){
          System.out.println(dept.getDeptNo() + "\t" + dept.getdName() + "\t" + dept.getLoc());
        }
      }
      // HibernateUtil.closeSession();
    }else{
      System.out.println("未找到结果！");
      // HibernateUtil.closeSession();
    }

  }

  public static Integer save(Integer x){
    Session session = getSession();
    Transaction tx = session.beginTransaction();
    Integer i = 0;
    if(null == query(x)){
      i = (Integer)session.save(new Dept(new Integer(x),"Tmp","WoTaiHua"));
      tx.commit();
    }
    // tx.commit();
    // session.getTransaction().commit();
    // HibernateUtil.closeSession();
    System.out.println("返回主键:" + i);
    return i;
  }

  public void saveOrUpdate(Integer x){
    
  }

  public void merge(Integer x){
    
  }

  public static void update(){
    Session session = getSession();
    Transaction tx = session.beginTransaction();
    Dept dept = query(1);//(Dept)session.get(Dept.class,new Integer(1));
    if(null != dept){
      // dept.setdName("技术部");
      // dept.setLoc("ChengDu");
      dept.setLoc("BeiJing");
    }
    tx.commit();
    // HibernateUtil.closeSession();
  }

  public static void del(Integer i){
    Session session = getSession();
    Transaction tx = session.beginTransaction();
    Dept dept = query(save(i));
    if(null != dept){
      session.delete(dept);
      tx.commit();
    }
    // HibernateUtil.closeSession();
  }

  public static void main(String... args){
    // tmp();
    // save();
    // update();
    // tmp(1);
    // queryAllDept();
    del(3);
  }

}