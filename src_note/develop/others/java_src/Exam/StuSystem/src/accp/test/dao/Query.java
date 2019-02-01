package accp.test.dao;
import java.util.*;
import java.sql.*;
import accp.test.entity.Standard;

public class Query extends BaseDao{
	/*
	 * id
	 * stdNum
	 * zhname
	 * version
	 * keys
	 * releaseDate
	 * implDate
	 * package
	 */
	
  public List queryInfo(){
	  String sql = "select * from standard";
	  List list = null;
	  Connection con = super.getConn();
	  PreparedStatement pst = null;
	  ResultSet rs = null;
	  try {
		pst = con.prepareStatement(sql);
		rs = pst.executeQuery();
		if(rs.next()){
			Standard stand = new Standard();
			stand.setId(rs.getInt("id"));
			stand.setStdNum(rs.getString("stdNum"));
			stand.setZhname(rs.getString("zhname"));
			stand.setVersion(rs.getString("version"));
			stand.setKeys(rs.getString("keys"));
			stand.setReleaseDate(rs.getDate("releaseDate"));
			stand.setImplDate(rs.getDate("implDate"));
			stand.setPackAge(rs.getString("package"));
			list.add(stand);
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
