package test.tmp;

import java.lang.reflect.ParameterizedType;
import java.util.List;
import org.hibernate.Query;
import org.hibernate.Session;
import test.util.HibernateUtil;
import java.lang.reflect.Type;

public class ReflectDao<T> {
  private Class<T> clasz;

  @SuppressWarnings("unchecked")
  public ReflectDao(){
    // this.getClass().getGenericSuperclass()).getActualTypeArguments()[0];
    System.out.println(this.getClass().getName());
    System.out.println(this.getClass().getGenericSuperclass().toString());
    Type type = this.getClass().getGenericSuperclass();
    System.out.println(type);
    ParameterizedType pType = (ParameterizedType) type;
    System.out.println(pType);
    clasz = (Class<T>) pType.getActualTypeArguments()[0];
    System.out.println(clasz);
  }

  @SuppressWarnings("unchecked")
  public List<T> queryList(String hql){
    Session session = HibernateUtil.getCurrentSession();
    Query query = session.createQuery(hql);
    List<T> list = query.list();
    if(null != session){
      HibernateUtil.closeSession();
    }
    return list;
  }
  
}
