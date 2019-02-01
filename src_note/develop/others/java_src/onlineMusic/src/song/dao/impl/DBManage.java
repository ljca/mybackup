package song.dao.impl;
import org.apache.commons.dbutils.*;
import java.sql.*;
public class DBManage{
static{
 DbUtils.loadDriver("com.mysql.jdbc.Driver");
 }

private static Connection conn = null;
public Connection getConn(){
  try{
  return conn == null ? DriverManager.getConnection("jdbc:mysql://localhost/song?user=mysql&password=mysql"):conn;
  }catch(SQLException e){
    System.out.println();//error();//.print();//true;
  }
  return null;
}

public void cloALLCon(Connection con,Object... paras){
  try{
    if(null!=con){
      con.close();
    }
  }catch(SQLException e){
      System.out.println(e);
  }
  paras = new Object[]{conn};
}

}


