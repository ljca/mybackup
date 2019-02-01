package exam.leave.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.PreparedStatement;

public class BaseDao{
  /**
   * 加载驱动
   */
  static{
    try{
      Class.forName("com.mysql.jdbc.Driver");
    }catch(ClassNotFoundException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }
  }

  /**
   * 获取数据库连接
   * @return
   */
  public Connection getConn(){
    Connection conn = null;
    try{
      conn = DriverManager.getConnection("jdbc:mysql://localhost:3306/Leave?user=mysql&password=mysql");
    }catch(SQLException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }
    return conn;
  }

  /**
   * 关闭对象
   * @param rs
   * @param pst
   * @param conn
   */
  public void closeAll(ResultSet rs,PreparedStatement pst,Connection conn){
    try{
      if(null != rs){
        rs.close();
      }
      if(null != pst){
        pst.close();
      }
      if(null != conn){
        conn.close();
      }
    }catch(SQLException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }
  }

}
