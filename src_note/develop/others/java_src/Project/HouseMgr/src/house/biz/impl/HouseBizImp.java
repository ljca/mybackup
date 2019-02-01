package house.biz.impl;

import java.util.List;
import house.biz.IHouseBiz;
import house.dao.impl.BaseDao;
import house.dao.impl.HouseDaoImpl;
import house.entity.House;
import house.entity.Users;
import house.page.support.PageUtil;

public class HouseBizImp implements IHouseBiz{

  @Override
  public PageUtil queryAllHouse(){
    PageUtil page = new PageUtil();
    page.setCurrentPage(1);
    page.setPageSize(5);
    List<House> list = new HouseDaoImpl().queryAllHouse("from House h",page.getCurrentPage(),page.getPageSize());
    page.setList(list);
    return page;
  }

}
