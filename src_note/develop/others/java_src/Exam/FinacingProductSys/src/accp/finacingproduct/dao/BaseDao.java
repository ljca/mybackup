package accp.finacingproduct.dao;
import java.sql.*;

public class BaseDao {
	
	/**
	 * ����sqlserver����
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
	 * ��ȡ���ݿ����Ӷ���
	 * @return �������ݿ����Ӷ���
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
	 * �ر����ݿ�����
	 * @param rs ���������
	 * @param pst sqlԤ�������
	 * @param con ���Ӷ���
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
