package accp.test.dao;
import java.sql.*;

/**
 * 返回连接对象
 * @author YL_HH_GG
 */
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
			con = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;DatabaseName=Work","sa","512xie36");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return con;
	}

	/**
	 * 关闭数据库访问连接
	 * @param rs
	 * @param pst
	 * @param con
	 */
	public void closeAll(ResultSet rs,PreparedStatement pst,Connection con){
		try {
			if(null != rs){
				rs.close();
			}if(null != pst){
				pst.close();
			}if(null != con){
				con.close();
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
}
