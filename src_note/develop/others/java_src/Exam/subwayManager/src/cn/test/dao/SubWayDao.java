package cn.test.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import cn.test.entity.SubWayInfo;

public class SubWayDao extends BaseDao{
  /*
  ID
  SUBWAYNAME
  STARTSTATION
  ENDSTATION
  STATIONNUM
  STARTTIME
  PRICE
  */
  public List<SubWayInfo> queryAll() {
    String sql = "select * from subwayInfo";
    List<SubWayInfo> list = new ArrayList<SubWayInfo>();
    Connection con = super.getConn();
    PreparedStatement pst = null;
    ResultSet rs = null;
    try{
      pst = con.prepareStatement(sql);
      rs = pst.executeQuery();
      while(rs.next()){
        SubWayInfo sub = new SubWayInfo();
        sub.setId(rs.getInt("ID"));
        sub.setSubwayName(rs.getString("SUBWAYNAME"));
        sub.setStartStation(rs.getString("STARTSTATION"));
        sub.setEndStation(rs.getString("ENDSTATION"));
        sub.setStationNum(rs.getInt("STATIONNUM"));
        sub.setStartTime(rs.getString("STARTTIME"));
        sub.setPrice(rs.getInt("PRICE"));
        list.add(sub);
      }
    }catch(SQLException e){
      // TODO 自动生成的 catch 块
      e.printStackTrace();
    }finally {
      super.closeAll(rs,pst,con);
    }
    return list;
  }
  
  public SubWayInfo queryByID(int id) {
    SubWayInfo sub = null;
    Connection con = super.getConn();
    PreparedStatement pst = null;
    ResultSet rs = null;
    String sql = "select * from subwayInfo where ID = ?";
    try{
      pst = con.prepareStatement(sql);
      pst.setInt(1,id);
      rs = pst.executeQuery();
      if(rs.next()){
        sub = new SubWayInfo();
        sub.setId(rs.getInt("ID"));
        sub.setSubwayName(rs.getString("SUBWAYNAME"));
        sub.setStartStation(rs.getString("STARTSTATION"));
        sub.setEndStation(rs.getString("ENDSTATION"));
        sub.setStationNum(rs.getInt("STATIONNUM"));
        sub.setStartTime(rs.getString("STARTTIME"));
        sub.setPrice(rs.getInt("PRICE"));
      }
    }catch(SQLException e){
      // TODO 自动生成的 catch 块
      e.printStackTrace();
    }finally {
      super.closeAll(rs,pst,con);
    }
    return sub;
  }
  
  public static void main(String[] args){
    for(SubWayInfo s : new SubWayDao().queryAll()){
      System.out.println(s.getId() + "\t" + s.getSubwayName() + "\t" + s.getStartStation() + "\t"
          + s.getEndStation() + "\t" + s.getStationNum() + "\t" + s.getStartTime() + "\t" + s.getPrice());
    }
    SubWayInfo s = new SubWayDao().queryByID(3);
    System.out.println(s.getEndStation());
  }
  
}
