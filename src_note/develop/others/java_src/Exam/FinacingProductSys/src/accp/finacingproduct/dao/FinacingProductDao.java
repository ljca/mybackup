package accp.finacingproduct.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import accp.finacingproduct.entity.FinacingProduct;

public class FinacingProductDao extends BaseDao {

  FinacingProduct fintmp = null;

  /**
   * ��ѯ������Ƽ�¼����ӵ�һ������
   * 
   * @return ���ؼ���
   */
  public List queryFinacingProduct() {
    List list = new ArrayList();
    String sql = "select * from FinacingProduct";// select * from
                                                 // FinacingProduct";
    Connection con = super.getConn();
    PreparedStatement pst = null;
    ResultSet rs = null;
    try {
      pst = con.prepareStatement(sql);
      rs = pst.executeQuery();

      /*
       * Id Risk Income SaleStarting SaleEnd End
       */
      while (rs.next()) {
        fintmp = new FinacingProduct();
        fintmp.setId(rs.getString("Id"));
        fintmp.setRisk(rs.getInt("Risk"));
        fintmp.setIncome(rs.getString("Income"));
        fintmp.setSaleStarting(rs.getDate("SaleStarting"));
        fintmp.setSaleEnd(rs.getDate("SaleEnd"));
        fintmp.setEnd(rs.getDate("End"));
        list.add(fintmp);
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
   * ��ݲ�Ʒ����ͷ��յȼ�ģ���ѯ�����Ϣ
   * 
   * @param id
   *          ��Ʒ����
   * @param risk
   *          ���յȼ�
   * @return ���ز�ѯ��¼
   */
  public List queryList(String id, int risk) {
    String sql = "select * from FinacingProduct where id like ? and risk = ?";
    List list = null;
    Connection con = super.getConn();
    PreparedStatement pst = null;
    ResultSet rs = null;
    try {
      pst = con.prepareStatement(sql);
      pst.setString(1, id);
      pst.setInt(2, risk);
      rs = pst.executeQuery();
      if (rs.next()) {
        fintmp = new FinacingProduct();
        fintmp.setId(rs.getString("Id"));
        fintmp.setRisk(rs.getInt("Risk"));
        fintmp.setIncome(rs.getString("Income"));
        fintmp.setSaleStarting(rs.getDate("SaleStarting"));
        fintmp.setSaleEnd(rs.getDate("SaleEnd"));
        fintmp.setEnd(rs.getDate("End"));
        list.add(fintmp);
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
   * ������¼
   * 
   * @return FinacingProduct����
   */
  public FinacingProduct addFinacingProduct() {
    FinacingProduct fina = null;
    return fina;
  }
}
