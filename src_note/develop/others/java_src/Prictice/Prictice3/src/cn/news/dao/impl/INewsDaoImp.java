package cn.news.dao.impl;
import java.sql.*;
import java.util.*;
import cn.news.dao.INewsDao;
import cn.news.entity.News;

public class INewsDaoImp extends BaseDao implements INewsDao{
	/*
	 * 
	 * NID
NTID
NTITLE
NAUTHOR
NCREATEDATE
NPICPATH
NCONTENT
NMODIFYDATE
NSUMMARY
	 */	
	
	@Override
	public List queryNews() {
		String sql = "select * from [news]";
		List list = new ArrayList();
		Connection con = super.getConn();
		PreparedStatement pst = null;
		ResultSet rs = null;
		
		try {
			pst = con.prepareStatement(sql);
			rs = pst.executeQuery();
			while(rs.next()){
				News news = new News();
				news.setNid(rs.getInt("NID"));
				news.setNtid(rs.getInt("NTID"));
				news.setNtitle(rs.getString("NTITLE"));
				news.setNauthor(rs.getString("NAUTHOR"));
				news.setNcreateDate(rs.getDate("NCREATEDATE"));
				news.setNpicPath(rs.getString("NPICPATH"));
				news.setNcontent(rs.getString("NCONTENT"));
				news.setNmodifyDate(rs.getDate("NMODIFYDATE"));
				news.setNsummary(rs.getString("NSUMMARY"));
				list.add(news);
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}finally{
			super.closeAll(rs, pst, con);
		}
		return list;
	}
	

}

