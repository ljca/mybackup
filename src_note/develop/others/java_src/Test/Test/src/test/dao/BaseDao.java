package test.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.List;

import org.apache.commons.dbutils.DbUtils;
import org.apache.commons.dbutils.QueryRunner;
import org.apache.commons.dbutils.handlers.BeanHandler;
import org.apache.commons.dbutils.handlers.BeanListHandler;


public class BaseDao{

  static{
    DbUtils.loadDriver("com.mysql.jdbc.Driver");
  }

  /*
   * 获得临时用户表实体类
   * @return
   */
  /*
  public Class getUser(){
    Class tempuser = null;
    try{
      tempuser = Class.forName("test.entity.TempUser");
    }catch(ClassNotFoundException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }
    return tempuser;
  }
   */

  public BaseDao(){}

  public static Connection openCon(){
    Connection con = null;
    try{
      con = DriverManager.getConnection("jdbc:mysql://localhost/test?user=root&password=root");
      con.setAutoCommit(false);
    }catch(SQLException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }
    return con;
  }

  /**
   * 连接对象
   */
  private static Connection conn = null;

  /**
   * 获取所有用户名和密码
   * @param sql 查询sql
   * @return 所有用户的集合
   */
  /*@SuppressWarnings({"rawtypes","unchecked"})
  public List<TempUser> queryAll(String sql){
    conn = openCon();
    List<TempUser> list = null;
    QueryRunner qRunner = new QueryRunner();
    try{
      list = (List<TempUser>)qRunner.query(conn,sql,new BeanListHandler(TempUser.class));
    }catch(SQLException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }finally{
      try{
        DbUtils.commitAndClose(conn);
      }catch(SQLException e){
        // TODO Auto-generated catch block
        e.printStackTrace();
      }
    }
    return list;
  }

  @SuppressWarnings({"unchecked","rawtypes"})
  public Object queryList(String sql){
    conn = openCon();
    Object object = null;
    QueryRunner runner = new QueryRunner();
    try{
      object = runner.query(conn,sql,new BeanHandler(TempUser.class));
    }catch(SQLException e){
      e.printStackTrace();
    }finally{
      DbUtils.closeQuietly(conn);
    }
    return object;
  }

  public static void main(String...args){
    for(TempUser tmpuser : new BaseDao().queryAll("select * from tmp_user ")){
      System.out.println(tmpuser.getUser_name() + "\t" + tmpuser.getUser_pwd()); 
    }
    TempUser tmpuserTempUser = (TempUser) new BaseDao().queryList("select * from tmp_user where user_name='root'");
    System.out.println(tmpuserTempUser.getUser_name() + "\t" + tmpuserTempUser.getUser_pwd()); 
  }*/

}