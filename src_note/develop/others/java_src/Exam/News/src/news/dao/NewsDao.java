package news.dao;
import java.util.List;
import news.entity.News;



public interface NewsDao {
  public abstract List<News> queryNews(int pageSize,int currPage); 
  
  public abstract int getTotalCount();
  
  
  
}
