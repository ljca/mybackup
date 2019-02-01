package auction.web;

import java.util.List;

public class Page<E>{

  /**
   * 页面大小: 每页显示记录数。默认5条
   */
  private Integer pageSize = 5;

  /**
   * 当前页码: 默认为1
   */
  private Integer currentNo = 1;

  /**
   * 总页数
   */
  private Integer totalPage = 1;

  /**
   * 总记录数
   */
  private Integer totalCount = 1;

  /**
   * 查询集合
   */
  private List<E> list = null;

  public Integer getPageSize(){
    return pageSize;
  }

  public void setPageSize(Integer pageSize){
    this.pageSize = pageSize;
  }

  public Integer getCurrentSize(){
    return currentNo;
  }

  public void setCurrentSize(Integer currentNo){
    this.currentNo = currentNo;
  }

  public Integer getTotalPage(){
    return totalPage;
  }

  public void setTotalPage(Integer totalPage){
    this.totalPage = totalPage;
  }

  public Integer getTotalCount(){
    return totalCount;
  }

  public void setTotalCount(Integer totalCount){
    this.totalCount = totalCount;
  }

  public List<E> getList(){
    return list;
  }

  public void setList(List<E> list){
    this.list = list;
  }

}
