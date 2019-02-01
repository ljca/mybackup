package house.biz;

import java.util.List;

public interface IUserBiz<E>{
  /**
   * 用户登录验证
   * @param entity
   * @return
   */
  public abstract E login(E entity);

  /**
   * 用户注册
   * @param entity
   * @return
   */
  public abstract Integer regester(E entity);

  /**
   * 载入所有用户
   * @return
   */
  public abstract List<E> queryAllUsers();
}
