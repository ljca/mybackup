package easybuy.dao.impl;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.List;
import java.util.Map;
import org.apache.commons.dbutils.RowProcessor;
import org.apache.commons.dbutils.handlers.AbstractListHandler;
import easybuy.dao.ProductDao;
import easybuy.entity.Product;

/**
 * ProductDaoImp:ProductDao接口实现类
 * @author YL_HH_GG
 * @param <T>
 * 
 */
public class ProductDaoImpl<T> extends BaseDao<Product> implements ProductDao{
 RowProcessor rowProcessor = new RowProcessor(){
  @Override
  public Map<String, Object> toMap(ResultSet arg0) throws SQLException{
    // TODO Auto-generated method stub
    return null;
  }
  
  @Override
  public <T> List<T> toBeanList(ResultSet rs,Class<T> arg1) throws SQLException{
    // TODO Auto-generated method stub
    return null;
  }
  
  /**
   * ep_id 编号 自动编号（标识列），从1开始，主键 ep_name 名字 ep_description 描述 ep_price 价格
   * ep_stock 库存 epc_id 分类ID epc_child_id 二级分类ID ep_file_name 文件名
   */
  @SuppressWarnings("unchecked")
  @Override
  public <T> T toBean(ResultSet rs,Class<T> arg1) throws SQLException{
    Product product = new Product();
    product.setEpId(rs.getInt("ep_id"));
    product.setEpName(rs.getString("ep_name"));
    product.setEpDescription(rs.getString("ep_description"));
    product.setEpPrice(rs.getDouble("ep_price"));
    product.setEpStock(rs.getInt("ep_stock"));
    product.setEpcId(rs.getInt("epc_id"));
    product.setEpcChildId(rs.getInt("epc_child_id"));
    product.setEpFileName(rs.getString("ep_file_name"));
    return (T) product;
  }

  @Override
  public Object[] toArray(ResultSet rs) throws SQLException{
    return null;
  }
 
};
  

@SuppressWarnings({"unused","rawtypes"})
private AbstractListHandler handler = new AbstractListHandler<Product>(){
  protected Product handleRow(ResultSet rs) throws SQLException {
    Product product = new Product();
    product.setEpId(rs.getInt("ep_id"));
    product.setEpName(rs.getString("ep_name"));
    product.setEpDescription(rs.getString("ep_description"));
    product.setEpPrice(rs.getDouble("ep_price"));
    product.setEpStock(rs.getInt("ep_stock"));
    product.setEpcId(rs.getInt("epc_id"));
    product.setEpcChildId(rs.getInt("epc_child_id"));
    product.setEpFileName(rs.getString("ep_file_name"));
    return product;
  }
};

  @SuppressWarnings("unchecked")
  @Override
  public List<Product> queryProducts(Integer pageSize,Integer currentPage){
    return super.queryProducts("select * from easybuy_product limit ?,?",handler,(currentPage -1)*pageSize,pageSize);
  }
 
  @Override
  public Product queryById(Integer id){
    // TODO Auto-generated method stub
    return null;
  }

  @Override
  public Integer queryProductCount(){
    return super.queryProductCount("select count(1) from easybuy_product ");
  }

}
