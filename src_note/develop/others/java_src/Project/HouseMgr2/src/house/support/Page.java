package house.support;

import java.util.List;

/**
 * @author tmp
 *
 * @param <E>
 */
public class Page<E>{
  /**
   * 
   */
  private static final Long TOTAL_COUNT = 2L;
  
  /**
   * 
   */
  private Integer currentSize;
  
  /**
   * 
   */
  private Integer pageSize;
  
  /**
   * 
   */
  private Integer totalPage;
  
  /**
   * 
   */
  private List<E> list;
  
  /**
   * 
   */
  private Boolean hasPre;
  
  /**
   * 
   */
  private Boolean hasNext;

  /**
   * @return the currentSize
   */
  public Integer getCurrentSize(){
    return currentSize;
  }

  /**
   * @param currentSize the currentSize to set
   */
  public void setCurrentSize(Integer currentSize){
    this.currentSize = currentSize;
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
   * @return the totalPage
   */
  public Integer getTotalPage(){
    return totalPage;
  }

  /**
   * @param totalPage the totalPage to set
   */
  public void setTotalPage(Integer totalPage){
    this.totalPage = totalPage;
  }

  /**
   * @return the list
   */
  public List<E> getList(){
    return list;
  }

  /**
   * @param list the list to set
   */
  public void setList(List<E> list){
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
   * @return the totalCount
   */
  public static Long getTotalCount(){
    return TOTAL_COUNT;
  }
  
}