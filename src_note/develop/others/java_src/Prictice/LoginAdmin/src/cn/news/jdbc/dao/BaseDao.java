package cn.news.jdbc.dao;
import java.sql.*;

public class BaseDao {

	private Connection con = null;
	public Connection getConn(){
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
		} catch (ClassNotFoundException e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
		}
		   
		   if (null == con) {
			try {
				con = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;DatabaseName=Users","sa","512xie36");
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		   return con;
	}
	
	public void closeAll(ResultSet rs,PreparedStatement ps,Connection con){
		try {
			if(null != rs){
				rs.close();
			}
			if(null!= ps){
				ps.close();
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
