package cn.test.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import cn.test.entity.Feeling;

/*
f_id
f_title
f_content
f_date
f_type
*/
public class FeelingDao extends BaseDao{
  /**
   * 连接对象
   */
  Connection con = null;
  /**
   * 预编译对象
   */
  PreparedStatement pst = null;
  /**
   * sql
   */
  String sql;
  public List<Feeling> queryAll(){
    List<Feeling> list = new ArrayList<Feeling>();
    sql = "select * from feeling order by f_date desc ";
    con = super.getConn();
    ResultSet rs = null;
    try{
      pst = con.prepareStatement(sql);
      rs = pst.executeQuery();
      while(rs.next()){
        Feeling f = new Feeling();
        f.setFid(rs.getInt("f_id"));
        f.setFtitle(rs.getString("f_title"));
        f.setFcontent(rs.getString("f_content"));
        f.setFdate(rs.getDate("f_date"));
        f.setFtype(rs.getInt("f_type"));
        list.add(f);
      }
    }catch(SQLException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }finally{
      super.closeAll(rs,pst,con);
      pst = null;
      con = null;
    }
    return list;
  }
  
  public Feeling queryByID(int id){
    Feeling f = new Feeling();
    sql = "select * from feeling where f_id = ?";
    con = super.getConn();
    ResultSet rs = null;
    try{
      pst = con.prepareStatement(sql);
      pst.setInt(1,id);
      rs = pst.executeQuery();
      if(rs.next()){
        f.setFid(rs.getInt("f_id"));
        f.setFtitle(rs.getString("f_title"));
        f.setFcontent(rs.getString("f_content"));
        f.setFdate(rs.getDate("f_date"));
        f.setFtype(rs.getInt("f_type"));
      }
    }catch(SQLException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }finally{
      super.closeAll(rs,pst,con);
      pst = null;
      con = null;
    }
    return f;
  }
  
  
  public int add(Feeling f){
    int count = 0;
    sql = "insert into feeling values(?,?,?,?) ";
    con = super.getConn();
    try{
      pst = con.prepareStatement(sql);
      pst.setString(1,f.getFtitle());
      pst.setString(2,f.getFcontent());
      pst.setDate(3,new java.sql.Date(f.getFdate().getTime()));
      pst.setInt(4,f.getFtype());
      count = pst.executeUpdate();
    }catch(SQLException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }finally{
      super.closeAll(null,pst,con);
      pst = null;
      con = null;
    }
    return count;
  }
  
  public static void main(String[] args){
    for(Feeling fe : new FeelingDao().queryAll()){
      System.out.println(fe.getFcontent() + "\t" + fe.getFtitle());
    }
  }
}
