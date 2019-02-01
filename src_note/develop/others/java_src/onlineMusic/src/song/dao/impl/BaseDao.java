import java.util.*;
import java.lang.reflect.*;
import org.apache.commons.dbutils.DbUtils;
public class BaseDao<T>{
Class<T> clasz = null;
@SuppressWarnings("unchecked")
  public BaseDao(){
   ParameterizedType pType = (ParameterizedType)this.getClass().getGenericSuperclass();
   clasz = (Class<T>)pType.getActualTypeArguments()[0];
  }

}
