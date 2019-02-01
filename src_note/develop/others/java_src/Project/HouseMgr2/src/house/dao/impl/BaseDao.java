package house.dao.impl;

import hosue.util.HibernateUtil;

import java.io.Serializable;
import java.lang.reflect.ParameterizedType;
import org.hibernate.Query;
import org.hibernate.Session;

/**
 * @author tmp
 * 
 * @param <E>
 * @param <PrimparyKey>
 */
public class BaseDao<E,PrimparyKey extends Serializable>{
  @SuppressWarnings("unused")
  private Class<E> clasz;

  @SuppressWarnings("unchecked")
  public BaseDao(){
    ParameterizedType pType = (ParameterizedType)this.getClass().getGenericSuperclass();
    clasz = (Class<E>)pType.getActualTypeArguments()[0];
  }

  public Session getSession(){
    return HibernateUtil.getSession();
  }

  public void closeSession(){
    HibernateUtil.closeSession();
  }

  public Query getQuery(String hql){
    return this.getSession().createQuery(hql);
  }
  
  
  public Query getQuery(String hql,Object... params){
    Query query = this.getQuery(hql);
    if(null != query){
      for(int i = 0;i < params.length;i++){
        query.setParameter(i,params[i]);
      }
    }
    return query;
  }
  
  
  public E loadEnity(PrimparyKey id){
    
    return null;
  }

  @SuppressWarnings("unchecked")
  public E loadEnity(E e,String hql){
   return (E)(this.getQuery(hql).uniqueResult());
  }
  
  public void delEnity(){
    
  }

  public void updateEnity(){

  }
}
