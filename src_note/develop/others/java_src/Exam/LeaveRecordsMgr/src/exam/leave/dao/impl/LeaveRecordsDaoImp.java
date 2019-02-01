package exam.leave.dao.impl;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.sql.PreparedStatement;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import exam.leave.dao.BaseDao;
import exam.leave.dao.ILeaveRecordsDao;
import exam.leave.entity.LeaveRecords;

public class LeaveRecordsDaoImp extends BaseDao implements ILeaveRecordsDao{

  @Override
  public List<LeaveRecords> loadAllRecords(){
    List<LeaveRecords> list = new ArrayList<LeaveRecords>();
    Connection conn = null;
    PreparedStatement pst = null;
    ResultSet rs = null;
    conn = super.getConn();
    try{
      pst = conn.prepareStatement("select * from LeaveRecords");
      rs = pst.executeQuery();
      while(rs.next()){
        LeaveRecords leaveRecords = new LeaveRecords();
        leaveRecords.setId(rs.getInt("Id"));
        leaveRecords.setName(rs.getString("Name"));
        leaveRecords.setTime(rs.getDate("Time"));
        leaveRecords.setReason(rs.getString("Reason"));
        list.add(leaveRecords);
      }
    }catch(SQLException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }finally{
      super.closeAll(rs,pst,conn);
    }
    return list;
  }

  @Override
  public Integer addRecords(LeaveRecords leaveRecords){
    Integer count = 0;
    String sql = "insert into LeaveRecords(Name,Time,Reason) values(?,?,?)";
    Connection con = super.getConn();
    PreparedStatement pst = null;
    try{
      pst = con.prepareStatement(sql);
      pst.setString(1,leaveRecords.getName());
      pst.setDate(2,new java.sql.Date(leaveRecords.getTime().getTime()));
      pst.setString(3,leaveRecords.getReason());
      count = pst.executeUpdate();
    }catch(SQLException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }finally{
      super.closeAll(null,pst,con);
    }
    return count;
  }

  @Override
  public Integer delRecords(Integer id){
    Integer count = 0;
    String sql = "delete from LeaveRecords where Id =?";
    Connection conn = super.getConn();
    PreparedStatement pst = null;
    try{
      pst = conn.prepareStatement(sql);
      pst.setInt(1,id);
      count = pst.executeUpdate();
    }catch(SQLException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }finally{
      super.closeAll(null,pst,conn);
    }
    return count;
  }

 /* 
  public static void main(String[] args){

    LeaveRecords tmp = new LeaveRecords();
    tmp.setName("李季");
    tmp.setReason("未知请假原因");
    try{
      tmp.setTime(new SimpleDateFormat("yyyy-MM-dd").parse("2015-2-3"));
    }catch(ParseException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }
    new LeaveRecordsDaoImp().addRecords(tmp);

    //new LeaveRecordsDaoImp().delRecords(6);
    for(LeaveRecords tmp2 : new LeaveRecordsDaoImp().loadAllRecords()){
      System.out.println(tmp2.getId()+","+tmp2.getName());
    }
    
  }
*/
  
}
