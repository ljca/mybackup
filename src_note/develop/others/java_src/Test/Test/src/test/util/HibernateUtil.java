package test.util;

import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;

public class HibernateUtil{
  @SuppressWarnings("rawtypes")
  private static final ThreadLocal THREAD_LOCAL = new ThreadLocal();

  private static Configuration config = null;

  private static SessionFactory sf = null;
  static{
    try{
      config = new Configuration().configure();
      sf = config.buildSessionFactory();
    }catch(Throwable e){
      e.printStackTrace();
      throw new ExceptionInInitializerError(e);
    }
  }

  @SuppressWarnings("unchecked")
  public static Session getCurrentSession(){
    Session session = (Session) THREAD_LOCAL.get();
    if(null == session){
      session = sf.openSession();
      THREAD_LOCAL.set(session);
    }
    return session;
  }

  @SuppressWarnings("unchecked")
  public static void closeSession(){
    Session session = (Session) THREAD_LOCAL.get();
    if(null != session){
      THREAD_LOCAL.set(null);
      session.close();
    }
  }

}