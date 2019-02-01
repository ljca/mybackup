package easybuy.dao;
import java.util.List;


import easybuy.entity.Product;

/**
 * ProductDao:商品接口
 * @author YL_HH_GG
 */
public interface ProductDao{
  /**
   * 实现分页查询商品
   * @param pageSize  每页显示商品数
   * @param currentPage  当前页
   * @return 商品列表
   */
  public abstract List<Product> queryProducts(Integer pageSize,Integer currentPage);
  
  /**
   * 根据商品id查询商品详情
   * @param id 商品id
   * @return 商品详情
   */
  public abstract Product queryById(Integer id);

  /**
   * 查询商品总记录数
   * @return
   */
  public abstract Integer queryProductCount();
}
