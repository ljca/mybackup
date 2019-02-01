package easybuy.commons;
import java.util.List;
import easybuy.entity.Product;

public class PageBean<T>{
  
  /**
   * 每页默认显示商品数
   */
  public static final Integer DEFAULT_SIZE = 5; 
  
  /**
   * 分页显示当前页索引，从1开始，不得小于1或者超过商品列表总页数
   */
  private Integer currentPage;

  /**
   * 每页显示商品个数
   */
  private Integer pageSize; 
  
  /**
   * 商品总记录数
   */
  private Integer totalCount; 
  
  /**
   * 商品列表总页数
   */
  private Integer totalPage;

  /**
   * 分页显示中的商品列表是否存在下一页
   */
  private Boolean hasNaxt;
  
  private Boolean hasPre;

  /**
   * 每页要显示的商品
   */
  private List<T> productsList;

  /**
   * 获取当前页索引
   * @return
   */
  public Integer getCurrentPage(){
    if(currentPage == null){
      this.currentPage = 1;
    }
    return currentPage;
  }

  public void setCurrentPage(Integer currentPage){
    this.currentPage = currentPage;
  }

  /**
   * 获取每页显示商品数
   * 如果没有设置每页显示商品数，则默认每页显示5个商品
   * @return
   */
  public Integer getPageSize(){
    if(totalPage == null){
      totalPage = DEFAULT_SIZE;
    }
    return pageSize;
  }

  public void setPageSize(Integer pageSize){
    this.pageSize = pageSize;
  }

  /**
   * 获取数据库存在的商品总记录数
   * @return 商品总记录数
   */
  public Integer getTotalCount(){
    return totalCount;
  }

  public void setTotalCount(Integer totalCount){
    this.totalCount = totalCount;
  }

  /**
   * 获取商品显示总页数
   * @return 商品总页数
   */
  public Integer getTotalPage(){
   return totalPage = this.getTotalCount() % this.getPageSize()==0 ? this.getTotalCount()/this.getPageSize()
        : this.getTotalCount()/this.getPageSize()+1;
  }

  public void setTotalPage(Integer totalPage){
    this.totalPage = totalPage;
  }

  /**
   * 获取每页显示的商品集合
   * @return
   */
  public List<T> getProductsList(){
    return productsList;
  }

  public void setProductsList(List<T> productsList){
    this.productsList = productsList;
  }

  /**
   * 如果当前页大于等于商品总页数
   * @return
   */
  public Boolean getHasNaxt(){
    if(this.getCurrentPage() >= this.getTotalPage() || this.getCurrentPage() <= 1){
      hasNaxt = false;
    }else {
      hasNaxt = true;
    }
    return hasNaxt;
  }

  public void setHasNaxt(Boolean hasNaxt){
    this.hasNaxt = hasNaxt;
  }

 /**
  *  如果当前页索引为负数或者起始页
  */
  public Boolean getHasPre(){
    if(this.getCurrentPage() <= 1){
      hasPre = false;
    }else {
      hasPre = true;
    }
    return hasPre;
  }

  public void setHasPre(Boolean hasPre){
    this.hasPre = hasPre;
  }

}
