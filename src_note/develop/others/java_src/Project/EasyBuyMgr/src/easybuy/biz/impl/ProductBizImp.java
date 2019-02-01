package easybuy.biz.impl;

import java.util.List;
import easybuy.biz.ProductBiz;
import easybuy.commons.PageBean;
import easybuy.dao.ProductDao;
import easybuy.dao.impl.ProductDaoImpl;
import easybuy.entity.Product;

public class ProductBizImp  implements ProductBiz{

  @Override
  public PageBean<Product> loadProducts(Integer pageSize,Integer currentPage){
    PageBean<Product> page = new PageBean<Product>();
    ProductDao product = new ProductDaoImpl<Product>();
    page.setProductsList(product.queryProducts(pageSize,currentPage));
    page.setTotalCount(product.queryProductCount());
    page.setPageSize(pageSize);
    return page;
  }

  @Override
  public Product loadProduct(Integer id){
    // TODO Auto-generated method stub
    return new ProductDaoImpl().queryById(id);
  }
  
  public static void main(String[] args){
    @SuppressWarnings({"rawtypes","unused"})
    Integer tmp = new ProductDaoImpl().queryProductCount();
    @SuppressWarnings({"rawtypes","unchecked"})
    List<Product> list = new ProductDaoImpl().queryProducts(5,1);
    for(Product p : list){
      System.out.println(p.getEpName() + "\t" + p.getEpDescription() + "\t" + p.getEpFileName());
    }
  }

}
