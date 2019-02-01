package cn.accp.dao.impl;
import java.sql.*;

public class BaseDao {
	public Connection getConn(){
		Connection con = null;
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		if(null == con){
			try {
				con = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;DatabaseName=newsxql","sa","512xie36");
			} catch (SQLException e) {
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
			e.printStackTrace();
		}
	}

}
