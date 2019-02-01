package house.dao;

import java.util.List;

public interface IUserDao<E>{
  /**
   * 载入所有用户
   * @return
   */
  public abstract List<E> loadAllUsers(String hql);
  
  public abstract E loadUser(String hql,Object... paras);
  
  /**
   * 登录用户验证
   * @return
   */
  public abstract E login(E entity,String hql);
  public abstract E login(E entity);
  
  /**
   * 登录用户验证
   * @return
   */
  public abstract E login(String uname,String pwd);
  
  /**
   * 注册用户
   * @param u
   */
  public abstract Integer regesterUser(E u);
}
