package house.dao.impl;

import java.util.List;

import org.hibernate.Query;
import house.dao.IUserDao;
import house.entity.Users;

public class UserDaoImpl extends BaseDao<Users,Integer> implements IUserDao<Users>{

  @Override
  public List<Users> loadAllUsers(String hql){
    return super.queryList(hql);
  }

  @Override
  public Users login(Users entity){
    String hql = "from Users u where u.userName =:userName and u.passWord = :passWord";
    
    return (Users)super.getEntity(entity,hql);//getQuery(entity,hql).uniqueResult();
  }
  
  @Override
  public Users login(String uname,String pwd){
    return null;
  }

  @Override
  public Users login(Users entity,String hql){
    // TODO Auto-generated method stub
    return null;
  }

  @Override
  public Integer regesterUser(Users u){
    return super.saveEntity(u);
  }

  @Override
  public Users loadUser(String hql,Object... paras){
    return null;
    //super.getEntity(entity,hql);
  }
  
  public Users loadUser(){
    Query query = super.getQuery(" from House h inner join fetch h.users where h.users.id = ?");
    query.setParameter(0,3);
    List<Users> list = query.list();
    for(Users users:list){
      System.out.println("是否是管理员:?  "+users.getIsAdmin());
    }
    return super.loadEntity(Users.class,3);
    //return (Users)query.uniqueResult();
  }
  public static void main(String[] args){
    Users user = new UserDaoImpl().loadUser();System.out.println(user.getName());
  }
}