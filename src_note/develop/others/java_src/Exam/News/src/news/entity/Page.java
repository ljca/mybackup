package news.entity;
import java.util.List;

public class Page{

  private int totalPageCount = 1;

  private int totalCount = 0;

  private int pageSize = 0;

  private int currpageNo = 1;

  private List<News> newsList = null;

  public int getTotalPageCount(){
    return totalPageCount;
  }

  public void setTotalPageCount(int totalPageCount){
    this.totalPageCount = totalPageCount;
  }

  public int getTotalCount(){
    return totalCount;
  }

  public void setTotalCount(int totalCount){
    if(totalCount > 0){
      this.totalCount = totalCount;
      totalPageCount = this.totalCount % pageSize == 0 ? (this.totalCount / pageSize) : (this.totalCount / pageSize) + 1;
    }
  }

  public int getPageSize(){
    return pageSize;
  }

  public void setPageSize(int pageSize){
    this.pageSize = pageSize;
  }

  public int getCurrpageNo(){
    return currpageNo;
  }

  public void setCurrpageNo(int currpageNo){
    this.currpageNo = currpageNo;
  }

  public List<News> getNewsList(){
    return newsList;
  }

  public void setNewsList(List<News> newsList){
    this.newsList = newsList;
  }

}
