package house.dao.impl;

import java.io.Serializable;
import java.lang.reflect.ParameterizedType;
import java.util.List;
import house.util.HibernateUtil;
import org.hibernate.Criteria;
import org.hibernate.Query;
import org.hibernate.Session;

public class BaseDao<E,PrimaryKey extends Serializable>{
  @SuppressWarnings("unused")
  private Class<E> clasz;

  @SuppressWarnings("unchecked")
  public BaseDao(){
    ParameterizedType ptype = (ParameterizedType)this.getClass().getGenericSuperclass();
    clasz = (Class<E>)ptype.getActualTypeArguments()[0];
  }

  public static Session getSession(){
    return HibernateUtil.getCurrentSession();
  }

  public void closeSession(){
    HibernateUtil.closeSession();
  }

  public void setParameter(Query query,Object... params){
    if(null != query){
      for(int i = 0;i < params.length;i++){
        query.setParameter(i,params[i]);
      }
    }
  }
  
  /**public abstract void setParameter();*/
  public static Query getQuery(String hql,Object... params){
    Query query = getSession().createQuery(hql);
    if(null != query){
      for(int i = 0;i < params.length;i++){
        query.setParameter(i,params[i]);
      }
    }
    return query;
  }
  
  public Query getQuery(E entity,String hql){
    Query query = getQuery(hql);
    if(null != query){
      query.setProperties(entity);
    }
    return query;
  }
  
  public static Query getQuery(String hql){
    return getSession().createQuery(hql);
  }

  public Criteria getCriteria(Class<E> clasz){
    return getSession().createCriteria(clasz);
  }
  
  @SuppressWarnings("unchecked")
  /**
   * 根据oid和实体载入实体详情
   * @param claz实体
   * @param id 主键
   * @return
   */
  public E loadEntity(Class clasz,PrimaryKey id){
    return (E)getSession().load(clasz,id);
  }
  
  @SuppressWarnings("unchecked")
  public E getEnity(Class clasz,PrimaryKey id){
    return (E)getSession().get(clasz,id);
  }
  
  @SuppressWarnings("unchecked")
  public E getEntity(String hql,Object... params){
    return (E)getQuery(hql,params).uniqueResult();
  }
  
  @SuppressWarnings("unchecked")
  public E getEntity(E entity,String hql){
    Query query = getQuery(hql);
    if(null != query){
      query.setProperties(entity);
    }
    return (E)query.uniqueResult();
  }
  
  /**
   * 统计数据库表总记录数
   * @return
   */
  public static Long getTotalCount(String hql){
    return (Long)getQuery(hql).uniqueResult();
  }
  
  @SuppressWarnings("unchecked")
  /**
   * 分页查询
   * @param hql
   * @param curreSize 当前页码
   * @param pageSize 每页显示记录
   * @return
   */
  public List<E> queryList(String hql,Integer curreSize,Integer pageSize){
    List<E> list = null;
    Query query = getQuery(hql);
    query.setFirstResult((curreSize-1)*pageSize);
    query.setMaxResults(pageSize);
    list = query.list();
    return list;
  }

  @SuppressWarnings("unchecked")
  /**
   * 载入所有记录
   * @param hql
   * @return
   */
  public List<E> queryList(String hql){
    return getQuery(hql).list();
  }

  @SuppressWarnings("unchecked")
  /**
   * 提交一条记录
   * @param entity
   * @return
   */
  public PrimaryKey saveEntity(E entity){
    Session session = getSession();
    PrimaryKey pk = (PrimaryKey)session.save(entity);
    session.beginTransaction().commit();
    return pk;
  }
  
  public void saveOrUpdateEntity(E entity){
    getSession().saveOrUpdate(entity);
  }
  
  public void updateEntity(E entity){
    getSession().update(entity);
  }
  
  public void delEntity(Class<E> clasz,E entity){
    getSession().delete("",entity);
  }
  
  public void delEntity(Class claz,PrimaryKey id){
    getSession().delete(getEnity(claz,id));
  }
  
}
