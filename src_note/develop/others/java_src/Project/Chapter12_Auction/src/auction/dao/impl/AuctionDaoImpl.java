package auction.dao.impl;

import java.util.List;
import auction.dao.IAuctionDao;
import auction.entity.Auction;

public class AuctionDaoImpl extends BaseDao<Auction, Integer> implements IAuctionDao{

  @Override
  public List<Auction> queryAll(){
    
    return null;
  }
  
}
