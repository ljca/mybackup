package house.biz.impl;

import java.util.List;
import house.biz.IUserBiz;
import house.dao.impl.UserDaoImpl;
import house.entity.Users;

public class UserBizImpl implements IUserBiz<Users>{

  @Override
  public Users login(Users entity){
    return new UserDaoImpl().login(entity);
  }

  @Override
  public Integer regester(Users entity){
    // TODO Auto-generated method stub
    return new UserDaoImpl().saveEntity(entity);
  }

  @Override
  public List<Users> queryAllUsers(){
    // TODO Auto-generated method stub
    return new UserDaoImpl().loadAllUsers("from Users u");
  }

}
