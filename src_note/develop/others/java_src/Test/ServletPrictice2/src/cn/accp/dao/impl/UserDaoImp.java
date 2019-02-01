package cn.accp.dao.impl;
import cn.accp.dao.IUserDao;
import cn.accp.entity.Users;
import java.sql.*;

public class UserDaoImp extends BaseDao implements IUserDao{

	@Override
	public Users queryUser(Users usr) {
		Users user = null;
		Connection con = super.getConn();
		PreparedStatement pst = null;
		ResultSet rs = null;
		String sql = "select * from [news_users] where uname = ? and upwd = ?";
		try {
			user = new Users();
			pst = con.prepareStatement(sql);
			String name = usr.getUname();
			String pwd = usr.getUpwd();
			pst.setString(1, name);
			pst.setString(2, pwd);
			rs = pst.executeQuery();
			if(rs.next()){
				user.setUid(rs.getInt("uid"));
				user.setUname(rs.getString("uname"));
				user.setUpwd(rs.getString("upwd"));
			}
			
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}finally{
			super.closeAll(rs, pst, con);
		}
		return user;
	}

}
