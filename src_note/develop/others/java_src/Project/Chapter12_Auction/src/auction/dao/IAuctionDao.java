package auction.dao;

import java.util.List;
import auction.entity.Auction;

public interface IAuctionDao{
  List<Auction> queryAll();

}
