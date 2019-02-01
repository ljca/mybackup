package accp.test.dao;
import java.util.*;
import java.sql.*;
import accp.test.entity.Working;

public class WorkDao extends BaseDao{
	/*
	Id
	Title
	Content
	Date
	Type
	*/
	/**
	 * 查询所有工作记录
	 * @return
	 */
	public List queryContext(){
		Connection con = super.getConn();
		List list = new ArrayList();
		String sql = "select * from Working order by Date asc";
		PreparedStatement pst = null;
		ResultSet rs = null;
		Working work = null;
		try {
			pst = con.prepareStatement(sql);
			rs = pst.executeQuery();
			while(rs.next()){
				work = new Working();
				work.setId(rs.getInt("Id"));
				work.setTitle(rs.getString("Title"));
				work.setContent(rs.getString("Content"));
				work.setDate(rs.getDate("Date"));
				work.setType(rs.getInt("Type"));
				list.add(work);
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}finally{
			super.closeAll(rs, pst, con);
		}
		return list;
	}
	
	/**
	 * 
	 * @param work
	 * @return
	 */
	public int addContext(Working work){
		Connection con = super.getConn();
		List list = new ArrayList();
		String sql = "insert into Working(Title,Content,Type) values(???)";
		PreparedStatement pst = null;
		ResultSet rs = null;
		try {
			pst = con.prepareStatement(sql);
			rs = pst.executeQuery();
			while(rs.next()){
				work = new Working();
				work.setId(rs.getInt("Id"));
				work.setTitle(rs.getString("Title"));
				work.setContent(rs.getString("Content"));
				work.setDate(rs.getDate("Date"));
				work.setType(rs.getInt("Type"));
				list.add(work);
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}finally{
			super.closeAll(rs, pst, con);
		}
		return 0;
	}
	

}
