package news.dao.impl;
import java.sql.*;
import javax.sql.*;
import javax.naming.*;

public class BaseDao {
	static{
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}  
	  }
  public Connection openCon(){
	  Connection con = null;
	  DataSource ds = null;
	  Context ctx = null;
	  
	  if(null == con){
		 /*
		  try {
			ctx = new InitialContext();
			ds = (DataSource)ctx.lookup("java:comp/env/jdbc/news");
		} catch (NamingException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		*/
		  try {
			con = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;DatabaseName=newsxql","sa","512xie36");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} 
	  }
	  return con;
  }
  
  public void closeAll(ResultSet rs,PreparedStatement pst,Connection con){
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
