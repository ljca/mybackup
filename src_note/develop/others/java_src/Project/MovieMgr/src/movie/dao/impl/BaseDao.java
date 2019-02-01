package movie.dao.impl;

import java.io.Serializable;
import java.lang.reflect.ParameterizedType;

public class BaseDao<E,PrimaryKey extends Serializable>{
  Class<E> clasz = null;
  @SuppressWarnings("unchecked")
  public BaseDao(){
    ParameterizedType pType = (ParameterizedType) this.getClass().getGenericSuperclass();
    clasz = (Class<E>) pType.getActualTypeArguments()[0];
  }

}
