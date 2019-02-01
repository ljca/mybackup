package cn.test.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class BaseDao {
  static{
    try{
      Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
    }catch(ClassNotFoundException e){
      e.printStackTrace();
    }
  }

  public Connection getConn(){
    Connection con = null;
    try{
      con = DriverManager.getConnection("jdbc:sqlserver://localhost;DatabaseName=subway","sa","512xie36");
    }catch(SQLException e){
      // TODO 自动生成的 catch 块
      e.printStackTrace();
    }
    return con;
  }

  public void closeAll(ResultSet rs,PreparedStatement pst,Connection con){
    try{
      if(null != rs){
        rs.close();
      }
      if(null != con){
        con.close();
      }
      if(null != con){
        con.close();
      }
    }catch(SQLException e){
      // TODO 自动生成的 catch 块
      e.printStackTrace();
    }
  }

}
