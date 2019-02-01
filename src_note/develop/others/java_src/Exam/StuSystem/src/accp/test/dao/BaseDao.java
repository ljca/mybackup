package accp.test.dao;
import java.sql.*;

public class BaseDao {
	static{
		try {
			Class.forName("com.microsoft.sqlserver.jdbc");
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	public Connection getConn(){
		Connection con = null;
		if(null == con){
			try {
				con = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;DatabaseName=Standard","sa","512xie36");
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
