package accp.test.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.List;

import accp.test.entity.Attence;

public class AttenceDao extends BaseDao{

  /*
  ID
  EMPNAME
  DEPT
  CHKDATE
  STATUS
   */

  public List<Attence> queryAll(){
    String sql = "select * from ATTENCE";
    List<Attence> list = new ArrayList<Attence>();
    Connection con = super.getConn();
    PreparedStatement pst = null;
    ResultSet rs = null;
    try {
      pst = con.prepareStatement(sql);
      rs = pst.executeQuery();
      Attence a = null;
      while (rs.next()) {
        a = new Attence();
        a.setId(rs.getInt("ID"));
        a.setEmpName(rs.getString("EMPNAME"));
        a.setDept(rs.getString("DEPT"));
        a.setChkDate(rs.getDate("CHKDATE"));
        a.setStatus(rs.getString("STATUS")); 
        list.add(a);
      }
    } catch (SQLException e) {
      // TODO Auto-generated catch block
      e.printStackTrace();
    }finally{
      super.closeAll(rs, pst, con);
    }    
    return list;
  }

  public int addEmp(Attence a){
    int count = 0;
    String sql = "insert into ATTENCE values(?,?,?,?)";
    Connection con = super.getConn();
    PreparedStatement pst = null;
    try {
      pst = con.prepareStatement(sql);
      pst.setString(1,a.getEmpName());
      pst.setString(2,a.getDept());
      pst.setString(3,new SimpleDateFormat("yyyy-MM-dd").format(a.getChkDate()));
      pst.setString(4,a.getStatus());
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
    for (Attence a : new AttenceDao().queryAll()) {
      System.out.println(a.getId() + "\t" + a.getEmpName() +  "\t" + a.getDept() +  "\t" + a.getChkDate() 
          +  "\t" + a.getStatus());
    }
  }

}
