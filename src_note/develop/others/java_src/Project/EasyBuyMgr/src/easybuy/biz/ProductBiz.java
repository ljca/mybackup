package easybuy.biz;
import easybuy.commons.PageBean;
import easybuy.entity.Product;

public interface ProductBiz{
  public abstract PageBean<Product> loadProducts(Integer pageSize,Integer currentPage);
  public abstract Product loadProduct(Integer id);
}
