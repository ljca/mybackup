package house.dao;

import java.util.List;

public interface IHouseDao<E>{

  /**
   * @param hql
   * @param curretSize
   * @param pageSize
   * @return
   */
  public abstract List<E> queryAllHouse(String hql,Integer curretSize,Integer pageSize);
  
  public abstract void releaseHouse(E entity);
}
