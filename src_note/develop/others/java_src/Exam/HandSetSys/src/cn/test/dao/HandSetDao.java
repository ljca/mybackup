package cn.test.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import cn.test.entity.HandSet;

public class HandSetDao extends BaseDao{

  /*
  HS_ID
  NAME_TYPE
  PRICE
  NETWORK_MODE
  NETWORK_TYPE
  FACADE
  SCREEN_SIZE
  FEEL_SCREEN
  */
  public List<HandSet> queryAll(){
    List<HandSet> list = new ArrayList<HandSet>();
    Connection con = super.getConn();
    PreparedStatement pst = null;
    ResultSet rs = null;
    String sql = "select * from HANDSET ";
    try {
      pst = con.prepareStatement(sql);
      rs = pst.executeQuery();
      while (rs.next()) {
        HandSet hand = new HandSet();
        hand.setHsID(rs.getInt("HS_ID"));
        hand.setNameType(rs.getString("NAME_TYPE"));
        hand.setPrice(rs.getInt("PRICE"));
        hand.setNetworkMode("NETWORK_MODE");
        hand.setNetworkType(rs.getString("NETWORK_TYPE"));
        hand.setFacade(rs.getString("FACADE"));
        hand.setScreenSize(rs.getString("SCREEN_SIZE"));
        hand.setFeelScreen(rs.getString("FEEL_SCREEN"));
        list.add(hand);
      }
      
    } catch (SQLException e) {
      // TODO Auto-generated catch block
      e.printStackTrace();
    }finally{
      super.closeAll(rs, pst, con);
    }
    return list;
  }
  
  public HandSet queryById(int id){
    HandSet h = null;
    Connection con = super.getConn();
    PreparedStatement pst = null;
    ResultSet rs = null;
    String sql = "select * from HANDSET where HS_ID=?";
    try {
      pst = con.prepareStatement(sql);
      pst.setInt(1, id);
      rs = pst.executeQuery();
      if (rs.next()) {
        h = new HandSet();
        h.setHsID(rs.getInt("HS_ID"));
        h.setNameType(rs.getString("NAME_TYPE"));
        h.setPrice(rs.getInt("PRICE"));
        h.setNetworkMode("NETWORK_MODE");
        h.setNetworkType(rs.getString("NETWORK_TYPE"));
        h.setFacade(rs.getString("FACADE"));
        h.setScreenSize(rs.getString("SCREEN_SIZE"));
        h.setFeelScreen(rs.getString("FEEL_SCREEN"));
      }
    } catch (SQLException e) {
      // TODO Auto-generated catch block
      e.printStackTrace();
    }finally{
      super.closeAll(rs, pst, con);
    }
    return h;
  }
  
  public int delHand(int id){
    int count = 0;
    Connection con = super.getConn();
    PreparedStatement pst = null;
    ResultSet rs = null;
    String sql = "delete HANDSET where HS_ID=?";
    try {
      pst = con.prepareStatement(sql);
      pst.setInt(1, id);
      count = pst.executeUpdate();
    } catch (SQLException e) {
      // TODO Auto-generated catch block
      e.printStackTrace();
    }finally{
      super.closeAll(null, pst, con);
    }
    return count;
  }
  
  
  public static void main(String[] args) {
    for (HandSet h : new HandSetDao().queryAll()) {
      System.out.println(h.getHsID() + "\t" + h.getNameType());
    }
    HandSet h = new HandSetDao().queryById(3);
    System.out.println(h.getFacade());
  }
  
}
