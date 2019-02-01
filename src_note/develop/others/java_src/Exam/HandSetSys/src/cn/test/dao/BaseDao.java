package cn.test.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;


public class BaseDao {
  static{
    try {
      Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
    } catch (ClassNotFoundException e) {
      // TODO Auto-generated catch block
      e.printStackTrace();
    }
  }
  public Connection getConn(){
    Connection con = null;
    try {
      con = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;DatabaseName=handset","sa","512xie36");
    } catch (SQLException e) {
      // TODO Auto-generated catch block
      e.printStackTrace();
    }
    return con;
  }
  
  
  public void closeAll(ResultSet rs,PreparedStatement pst,Connection con){
    try {
      if (rs != null) {
        rs.close();
      }
      if (pst != null) {
        pst.close();
      }
      if (con != null) {
        con.close();
      }
    } catch (SQLException e) {
      // TODO Auto-generated catch block
      e.printStackTrace();
    }
    
  }
  
}