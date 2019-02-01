package house.page.support;

import house.dao.impl.BaseDao;
import house.entity.House;
import java.util.List;

public class PageUtil{
  
  /**
   * 总记录数
   */
  private final Long TOTAL_COUNT = 2L;
  
  /**
   * 总页数
   */
  private Integer totalPage;
  
  private Integer pageSize = 1;
  
  private Integer currentPage;
  
  private List list;
  
  private Boolean hasPre;
  
  private Boolean hasNext;

  /**
   * @return the totalPage
   */
  public Integer getTotalPage(){
    return totalPage;
  }

  /**
   * @param totalPage the totalPage to set
   */
  public void setTotalPage(Integer totalPage){
    if(TOTAL_COUNT > 0){
      this.totalPage = (int)(this.getTOTAL_COUNT()/pageSize == 0 ? (this.getTOTAL_COUNT()/pageSize) : (this.getTOTAL_COUNT()/pageSize)+1);
    }
  }

  /**
   * @return the pageSize
   */
  public Integer getPageSize(){
    return pageSize;
  }

  /**
   * @param pageSize the pageSize to set
   */
  public void setPageSize(Integer pageSize){
    this.pageSize = pageSize;
  }

  /**
   * @return the currentPage
   */
  public Integer getCurrentPage(){
    return currentPage;
  }

  /**
   * @param currentPage the currentPage to set
   */
  public void setCurrentPage(Integer currentPage){
    this.currentPage = currentPage;
  }

  /**
   * @return the list
   */
  public List getList(){
    return list;
  }

  /**
   * @param list the list to set
   */
  public void setList(List list){
    this.list = list;
  }

  /**
   * @return the hasPre
   */
  public Boolean getHasPre(){
    return hasPre;
  }

  /**
   * @param hasPre the hasPre to set
   */
  public void setHasPre(Boolean hasPre){
    this.hasPre = hasPre;
  }

  /**
   * @return the hasNext
   */
  public Boolean getHasNext(){
    return hasNext;
  }

  /**
   * @param hasNext the hasNext to set
   */
  public void setHasNext(Boolean hasNext){
    this.hasNext = hasNext;
  }

  /**
   * @return the tOTAL_COUNT
   */
  public Long getTOTAL_COUNT(){
    return BaseDao.getTotalCount("select count(h.id) from House h");
  }
  
}
