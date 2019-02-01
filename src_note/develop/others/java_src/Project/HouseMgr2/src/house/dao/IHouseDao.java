/**
 * 
 */
package house.dao;

import house.support.Page;
import java.util.List;


/**
 * @author tmp
 *
 * @param <E>
 */
public interface IHouseDao<E>{ 
  /**
   * @param hql
   * @return
   */
  public abstract List<E> loadAllHouses(String hql);
  
  /**
   * @param hql
   * @param page
   * @return
   */
  public abstract List<E> loadAllHouses(String hql,Page page);
   
  /**
   * @return
   */
  public abstract List<E> loadHouse();
}
