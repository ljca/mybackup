package easybuy.dao.impl;

import java.sql.ResultSet;
import java.sql.SQLException;

import easybuy.dao.ResultMapper;
import easybuy.entity.Product;

public class ResulMapImpl implements ResultMapper{
  @Override
  
  /*
  +----------------+--------------+------+-----+---------+----------------+
  | Field          | Type         | Null | Key | Default | Extra          |
  +----------------+--------------+------+-----+---------+----------------+
  | ep_id          | int(11)      | NO   | PRI | NULL    | auto_increment |
  | ep_name        | varchar(15)  | NO   |     | NULL    |                |
  | ep_description | varchar(100) | NO   |     | NULL    |                |
  | ep_price       | double       | NO   |     | NULL    |                |
  | ep_stock       | int(11)      | NO   |     | NULL    |                |
  | epc_id         | int(255)     | NO   |     | NULL    |                |
  | epc_child_id   | int(255)     | YES  |     | NULL    |                |
  | ep_file_name   | varchar(20)  | YES  |     | NULL    |                |
  +----------------+--------------+------+-----+---------+----------------+
  */
  public Object reusultPro(ResultSet rs){
    Product p = new Product();
    try{
      p.setEpId(rs.getInt("ep_id"));
      p.setEpcChildId(rs.getInt("epc_child_id"));
      p.setEpcId(rs.getInt("epc_id"));
      p.setEpName(rs.getString("ep_name"));
      p.setEpPrice(rs.getDouble("ep_price"));
      p.setEpStock(rs.getInt("ep_stock"));
      p.setEpDescription(rs.getString("ep_description"));
      p.setEpFileName(rs.getString("ep_file_name"));
    }catch(SQLException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }
    return p;
  }

}
