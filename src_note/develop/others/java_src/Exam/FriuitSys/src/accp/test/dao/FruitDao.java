package accp.test.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import accp.test.entity.Fruit;

public class FruitDao extends BaseDao {

  /**
   * 查询所有水果记录
   * 
   * @return 返回水果集合
   */
  public List<Fruit> queryFruits() {
    List<Fruit> list = new ArrayList<Fruit>();
    String sql = "select * from FRUIT";
    Connection con = super.getConn();
    PreparedStatement pst = null;
    ResultSet rs = null;
    /*
     * FRUIT_ID TYPE BREED AREA BRICE WEIGHT PRICE
     */
    try {
      pst = con.prepareStatement(sql);
      rs = pst.executeQuery();
      while (rs.next()) {
        Fruit fruit = new Fruit();
        fruit.setFruitID(rs.getInt("FRUIT_ID"));
        fruit.setType(rs.getString("TYPE"));
        fruit.setBreed(rs.getString("BREED"));
        fruit.setArea(rs.getString("AREA"));
        fruit.setWeight(rs.getInt("WEIGHT"));
        fruit.setPrice(rs.getDouble("PRICE"));
        list.add(fruit);
      }

    } catch (SQLException e) {
      // TODO Auto-generated catch block
      e.printStackTrace();
    } finally {
      super.closeAll(rs, pst, con);
    }
    return list;
  }

  /**
   * 根据编号查询水果详情
   * 
   * @return 返回水果详情记录
   */
  public Fruit queryFruitsWithID(int id) {
    String sql = "select * from FRUIT where FRUIT_ID = ?";
    Connection con = super.getConn();
    PreparedStatement pst = null;
    ResultSet rs = null;
    Fruit fruit = null;
    try {
      pst = con.prepareStatement(sql);
      pst.setInt(1, id);
      rs = pst.executeQuery();
      while (rs.next()) {
        fruit = new Fruit();
        fruit.setFruitID(rs.getInt("FRUIT_ID"));
        fruit.setType(rs.getString("TYPE"));
        fruit.setBreed(rs.getString("BREED"));
        fruit.setArea(rs.getString("AREA"));
        fruit.setWeight(rs.getInt("WEIGHT"));
        fruit.setPrice(rs.getDouble("PRICE"));
        fruit.setBrice(rs.getString("BRICE"));
      }

    } catch (SQLException e) {
      // TODO Auto-generated catch block
      e.printStackTrace();
    } finally {
      super.closeAll(rs, pst, con);
    }
    return fruit;
  }

  /**
   * 根据水果编号删除水果记录
   * 
   * @param id
   *          水果编号
   * @return 执行结果
   */
  public int delFruit(int id) {
    int count = 0;
    String sql = "delete FRUIT where FRUIT_ID=?";
    Connection con = super.getConn();
    PreparedStatement pst = null;
    try {
      pst = con.prepareStatement(sql);
      pst.setInt(1, id);
      count = pst.executeUpdate();
    } catch (SQLException e) {
      // TODO Auto-generated catch block
      e.printStackTrace();
    } finally {
      super.closeAll(null, pst, con);
    }
    return count;
  }
  
  public int addFruit(Fruit f){
    String sql = "insert into FRUIT values(?,?,?,?,?,?)";
    int count = 0;
    Connection con = super.getConn();
    PreparedStatement pst = null;
    try {
      pst = con.prepareStatement(sql);
      pst.setString(1, f.getType());
      pst.setString(2, f.getBreed());
      pst.setString(3, f.getArea());
      pst.setString(4, f.getBrice());
      pst.setInt(5, f.getWeight());
      pst.setDouble(6, f.getPrice());
     count = pst.executeUpdate(); 
    } catch (SQLException e) {
      // TODO Auto-generated catch block
      e.printStackTrace();
    }finally{
      super.closeAll(null, pst, con);
    }   
    return count;
  }
  
}
