package cn.jdbc.dao.impl;
import java.util.*;
import javax.sql.*;
import java.sql.*;

public class BaseDao {
  Connection con = null;
  PreparedStatement pst = null;
  ResultSet rs = null;
  public Connection openCon(){
	  try {
		Class.forName("");
	} catch (ClassNotFoundException e) {
		// TODO Auto-generated catch block
		e.printStackTrace();
	}
	  if(null == con){
		  try {
			con = DriverManager.getConnection("","","");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	  }
	  return con;
  }
  
  public void conAll(ResultSet rs,PreparedStatement pst,Connection con){
	  try {
		  if(null != rs){
			  rs.close();
		  }
		  if(null != pst){
			  pst.close();
		  }
		  if(null != con){
			  con.close();
		  }
	} catch (SQLException e) {
		// TODO Auto-generated catch block
		e.printStackTrace();
	}
  }
  
}
