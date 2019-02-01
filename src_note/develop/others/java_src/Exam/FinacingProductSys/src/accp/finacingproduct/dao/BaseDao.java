package accp.finacingproduct.dao;
import java.sql.*;

public class BaseDao {
	
	/**
	 * 加载sqlserver驱动
	 */
	static{
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");//com.microsoft.sqlserver.jdbc");
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	/**
	 * 获取数据库连接对象
	 * @return 返回数据库连接对象
	 */
	public Connection getConn(){
		Connection con = null;
			try {
				con = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;DatabaseName=FinaProduct","sa","512xie36");
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		return con;
	}
	
	/**
	 * 关闭数据库连接
	 * @param rs 结果集对象
	 * @param pst sql预编译对象
	 * @param con 连接对象
	 */
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
