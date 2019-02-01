package cn.news.jdbc.dao;
import java.sql.*;
import java.util.*;

import cn.jdbc.entity.Users;

public class LogDaoImp extends BaseDao implements IUsersDao{

	@Override
	public List<Users> listUsr() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public Users questUsers(String uname, String pwd) {
	  Users user=null;
	  String sql = "select * from UserList where username=? and userpwd=?";
	  Connection con = super.getConn();
	  PreparedStatement ps = null;
	  ResultSet rs = null;
	  try {
		ps = con.prepareStatement(sql);
		ps.setString(1, uname);
		ps.setString(2, pwd);
		rs = ps.executeQuery();
		if (rs.next()) {
			user = new Users();
			user.setUsername(rs.getString("username"));
			user.setUserpwd(rs.getString("userpwd"));
		}
		
	} catch (SQLException e) {
		// TODO Auto-generated catch block
		e.printStackTrace();
	}finally{
		super.closeAll(rs, ps, con);
	}
	  return user;
 }
	
}
