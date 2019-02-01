package accp.test.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import accp.test.entity.StudentInfo;

/*
 sid
 sname
 sgender
 sage
 saddress
 smail
 */
public class StudentDao extends BaseDao {
  public List<StudentInfo> queryStudentInfonfos() {
    List<StudentInfo> list = new ArrayList<StudentInfo>();
    String sql = "select * from studentInfo";
    Connection con = super.getConn();
    PreparedStatement pst = null;
    ResultSet rs = null;
    try {
      pst = con.prepareStatement(sql);
      rs = pst.executeQuery();
      while (rs.next()) {
        StudentInfo stu = new StudentInfo();
        stu.setSid(rs.getInt("sid"));
        stu.setSname(rs.getString("sname"));
        stu.setSgender(rs.getString("sgender"));
        stu.setSage(rs.getInt("sage"));
        stu.setSaddress(rs.getString("saddress"));
        stu.setSmail(rs.getString("smail"));
        list.add(stu);
      }

    } catch (SQLException e) {
      // TODO: handle exception
    } finally {
      super.closeAll(rs, pst, con);
    }
    return list;
  }

  public List<StudentInfo> queryWithId(int id) {
    List<StudentInfo> list = new ArrayList<StudentInfo>();
    String sql = "select * from studentInfo where sid = ?";
    Connection con = super.getConn();
    PreparedStatement pst = null;
    ResultSet rs = null;
    try {
      pst = con.prepareStatement(sql);
      pst.setInt(1, id);
      rs = pst.executeQuery();
      while (rs.next()) {
        StudentInfo stu = new StudentInfo();
        stu.setSid(rs.getInt("sid"));
        stu.setSname(rs.getString("sname"));
        stu.setSgender(rs.getString("sgender"));
        stu.setSage(rs.getInt("sage"));
        stu.setSaddress(rs.getString("saddress"));
        stu.setSmail(rs.getString("smail"));
        list.add(stu);
      }
    } catch (SQLException e) {
      // TODO: handle exception
    } finally {
      super.closeAll(rs, pst, con);
    }
    return list;
  }

  public int updateWithId(int id) {
    String sql = "update studentInfo set sname=? and sgender=? and sage=? and saddress=? and smail=? where sid = ?";
    Connection con = super.getConn();
    StudentInfo stu = new StudentInfo();
    PreparedStatement pst = null;
    int count = 0;
    try {
      pst = con.prepareStatement(sql);
      pst.setString(1, stu.getSname());
      pst.setString(2, stu.getSgender());
      pst.setInt(3, stu.getSage());
      pst.setString(4, stu.getSaddress());
      pst.setString(5, stu.getSmail());
      pst.setInt(6, id);
      count = pst.executeUpdate();
    } catch (SQLException e) {
      // TODO Auto-generated catch block
      e.printStackTrace();
    } finally {
      super.closeAll(null, pst, con);
    }
    return count;
  }
}
