package cn.news.jdbc.dao;
import java.util.*;

import cn.jdbc.entity.*;

public interface IUsersDao {
	
	public abstract List<Users> listUsr();
	
	public abstract Users questUsers(String username,String passwd);
	
	
}
