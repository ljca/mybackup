package house.dao.impl;

import java.util.List;
import house.dao.IHouseDao;
import house.entity.House;
import house.entity.Users;
import house.page.support.PageUtil;

public class HouseDaoImpl extends BaseDao<House, Integer> implements IHouseDao<House>{

  @Override
  public List<House> queryAllHouse(String hql,Integer curretSize,Integer pageSize){
    return super.queryList(hql,curretSize,pageSize);
  }

  @Override
  public void releaseHouse(House entity){
    // TODO Auto-generated method stub
    
  }

}
