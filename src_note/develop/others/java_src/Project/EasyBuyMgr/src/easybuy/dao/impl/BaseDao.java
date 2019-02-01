package easybuy.dao.impl;
import java.lang.reflect.ParameterizedType;
import java.lang.reflect.Type;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.List;
import org.apache.commons.dbutils.DbUtils;
import org.apache.commons.dbutils.QueryRunner;
import org.apache.commons.dbutils.RowProcessor;
import org.apache.commons.dbutils.handlers.AbstractListHandler;
import org.apache.commons.dbutils.handlers.BeanHandler;
import org.apache.commons.dbutils.handlers.ScalarHandler;

public class BaseDao<T>{
  Class<T> clasz = null;
  @SuppressWarnings("unchecked")
  public BaseDao(){
    Type type = this.getClass().getGenericSuperclass();
    ParameterizedType ptType = (ParameterizedType)type;
    clasz = (Class<T>)ptType.getActualTypeArguments()[0];
  }
  
  static{
    DbUtils.loadDriver("com.mysql.jdbc.Driver");
  }

  QueryRunner qRunner = null;
  Connection con = null;
  public Connection getConn(){
    try{
      con = DriverManager.getConnection("jdbc:mysql://localhost/easybuy?user=root&password=root");
      con.setAutoCommit(false);
    }catch(SQLException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }
    return con;
  }
  
  /**
   * 查询所有商品
   * @param sql
   * @param handler
   * @param params
   * @return
   */
  public List<T> queryProducts(String sql,AbstractListHandler<T> handler,Object... params){
    List<T> list = null;
    con = this.getConn();
    qRunner = new QueryRunner();
    try{
      list = qRunner.query(con,sql,handler,params);
    }catch(SQLException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }finally{
      DbUtils.commitAndCloseQuietly(con);
    }
    return list;
  }

  public T queryEntity(String sql,RowProcessor rowprocess,Object... params){
    con = this.getConn();
    qRunner = new QueryRunner();
    T t = null;
    try{
     t = qRunner.query(con,null,new BeanHandler<T>(clasz,rowprocess),params);
    }catch(SQLException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }finally{
      DbUtils.commitAndCloseQuietly(con);
    }
    return t;
  }
  
  /**
   * 查询商品总数量
   * @param sql
   * @param parms
   * @return
   */
  public Integer queryProductCount(String sql,Object... parms){
    Long count = 0L;
    qRunner = new QueryRunner();
    con = this.getConn();
    try{
      count = qRunner.query(con,sql,new ScalarHandler<Long>(1),parms);
    }catch(SQLException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }
    return count.intValue();
  }
  
}
