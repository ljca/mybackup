package cn.jdbc.news.dao;
import java.sql.*;

import javax.naming.*;
import javax.sql.*;


public class BaseDao {
	  Connection con = null;
  public Connection openConnection(){
	  Context ctx = null;
	  DataSource ds = null;
	try {
		ctx = new InitialContext();
		ds = (DataSource)ctx.lookup("java:comp/env/jdbc/news");
	} catch (NamingException e1) {
		// TODO Auto-generated catch block
		e1.printStackTrace();
	}
	  try {
		    con = ds.getConnection();
	} catch (SQLException e) {
		// TODO Auto-generated catch block
		e.printStackTrace();
	}
	  return con;
  }
  
  public void closeCon(){
	  try {
		  if(null != con){
			  con.close();
		  }
	} catch (SQLException e) {
		// TODO Auto-generated catch block
		e.printStackTrace();
	}
  }
  
}
