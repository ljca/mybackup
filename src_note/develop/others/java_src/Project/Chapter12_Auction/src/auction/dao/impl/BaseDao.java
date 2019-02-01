package auction.dao.impl;
import java.io.Serializable;

import java.lang.reflect.*;
import java.util.List;
import org.hibernate.Criteria;
import org.hibernate.Query;
import org.hibernate.Session;

import auction.util.HibernateSessionFactory;

/**
 * 实体类 BaseDao
 * 
 * @author tmp
 * @param <E>
 *          实体类
 * @param <PrimaryKey>
 *          主键数据类型
 */
public class BaseDao<E,PrimaryKey extends Serializable>{
  private Class<E> clasz;

  @SuppressWarnings("unchecked")
  public BaseDao(){
    ParameterizedType pType = (ParameterizedType)(this.getClass().getGenericSuperclass());
    clasz = (Class<E>)pType.getActualTypeArguments()[0];
  }

  /**
   * 获取Session对象
   * @return Session对象
   */
  public static Session getSession(){
    return HibernateSessionFactory.getSession();
  }

  public static void setParameters(Query query,Object... params){
    if(null != params){
      for(int i = 0;i < params.length;i++){
        query.setParameter(i,params[i]);
      }
    }
  }
  
  
  /**
   * 获取 query对象
   * @param hql
   * @return query对象
   */
  public static Query getQuery(String hql,Object... params){
    Query query = getSession().createQuery(hql);
    setParameters(query,params);
    return query;
  }

  /**
   * 获取criteria对象
   * @param E
   * @return
   */
  public static Criteria getCriteria(Class<?> E){
    return getSession().createCriteria(E.getClass());
  }
  
  /**
   * 查询所有记录
   * @param hql
   * @param params
   * @return
   */
  @SuppressWarnings("unchecked")
  public List<E> queryAll(String hql,Integer currentNo,Integer pageSize,Object... params){
    Query query = getQuery(hql);
    List<E> list = null;
    setParameters(query,params);
    query.setFirstResult(currentNo);
    query.setMaxResults(pageSize);
    try{
      list = query.list();
    }catch(Exception e){
      // TODO: handle exceptio
    }finally{
      HibernateSessionFactory.closeSession();
    }
    return list;
  }

  /**
   * 查询所有记录
   * @param hql
   * @return
   */
  @SuppressWarnings("unchecked")
  public List<E> queryAll(String hql){
    List<E> list = null;
    try{
      list = getQuery(hql).list();
    }catch(Exception e){
      System.out.println(e);
    }finally{
      HibernateSessionFactory.closeSession();
    }
    return list;
  }

  /**
   * 根据id查询详情
   * 
   * @param t
   *          实体类
   * @param id
   *          主键id
   */
  @SuppressWarnings("unchecked")
  public E loadEnitity(PrimaryKey id){
    // Object object = getQuery("").uniqueResult();
    return (E)(getSession().load(clasz,id));
    // HibernateSessionFactory.closeSession();
    // return e;
  }

  /**
   * 保存
   * 
   * @param e
   * @return
   */
  @SuppressWarnings("unchecked")
  public PrimaryKey save(E e){
    Session session = HibernateSessionFactory.getSession();
    PrimaryKey id = (PrimaryKey)session.save(e);
    session.beginTransaction().commit();
    // HibernateSessionFactory.closeSession();
    return id;
  }

  /**
   * 删除
   * 
   * @param id
   */
  public void delete(E e,PrimaryKey id){
    Session session = getSession();
    session.delete((E)loadEnitity(id));
    session.beginTransaction().commit();
    // HibernateSessionFactory.closeSession();
  }
  
  public void update(E e){
    Session session = getSession();
    session.saveOrUpdate(e);
    session.beginTransaction().commit();
  }

}
