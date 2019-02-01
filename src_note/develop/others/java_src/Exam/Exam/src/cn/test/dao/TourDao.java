package cn.test.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import cn.test.entity.Tour;

public class TourDao extends BaseDao{

	public List<Tour> queryAll(){
		List<Tour> list = new ArrayList<Tour>();
		Connection con = super.getConn();
		PreparedStatement pst = null;
		ResultSet rs = null;
		String sql = "select * from tour";
		try{
			pst = con.prepareStatement(sql);
			rs = pst.executeQuery();
			while(rs.next()){
				Tour t = new Tour();
				t.setTourId(rs.getInt("tourId"));
				t.setTourCity(rs.getString("tourCity"));
				t.setTourPlace(rs.getString("tourPlace"));
				t.setTourTime(rs.getDate("tourTime"));
				t.setTourNote(rs.getString("tourNote"));
				list.add(t);
			}
		}catch(SQLException e){
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		}finally {
			super.closeAll(rs,pst,con);
		}
		return list;
	}

	public int addTour(Tour t) {
		int count = 0;
		Connection con = super.getConn();
		String sql = "insert into tour values(?,?,?,?)";
		PreparedStatement pst = null;
		try{
			pst = con.prepareStatement(sql);
			pst.setString(1,t.getTourCity());
			pst.setString(2,t.getTourPlace());
			pst.setDate(3,new java.sql.Date(t.getTourTime().getTime()));
			pst.setString(4,t.getTourNote());
			//pst.setInt(5,t.getTourId());
			count = pst.executeUpdate();
		}catch(SQLException e){
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		}finally {
			super.closeAll(null,pst,con);
		}
		return count;
	}

	public int delTour(int id) {
		int count = 0;
		Connection con = super.getConn();
		String sql = "delete tour where tourId = ?";
		PreparedStatement pst = null;
		try{
			pst = con.prepareStatement(sql);
			pst.setInt(1,id);
			count = pst.executeUpdate();
		}catch(SQLException e){
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		}
		return count;
	}

	public static void main(String[] args){
		/*
    Tour tx = new Tour();
    tx.setTourCity("法国");
    tx.setTourPlace("埃菲尔铁塔");
    try{
      tx.setTourTime(new SimpleDateFormat("yyyy-MM-dd").parse("2011-2-2"));
    }catch(ParseException e){
      // TODO 自动生成的 catch 块
      e.printStackTrace();
    }
    tx.setTourNote("曾经的第一高铁塔");
    if(new TourDao().addTour(tx) > 0){
      System.out.println("添加成功！");
      for(Tour t : new TourDao().queryAll()){      
        System.out.println(t.getTourId() + "\t" + t.getTourCity() + "\t" + t.getTourPlace() + "\t" + t.getTourTime() + "\t"
      + t.getTourNote());
      }
    }
		 */
		for(Tour t : new TourDao().queryAll()){      
			System.out.println(t.getTourId() + "\t" + t.getTourCity() + "\t" + t.getTourPlace() + "\t" + t.getTourTime() + "\t"
					+ t.getTourNote());

		}
	}
}
