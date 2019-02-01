package news.dao.impl;

import java.util.*;
import java.util.Date;
import java.sql.*;
import news.dao.*;
import news.entity.News;
import news.entity.Page;

public class NewsDaoImp extends BaseDao implements NewsDao{
  /*
   * NID NTID NTITLE NAUTHOR NCREATEDATE NPICPATH NCONTENT NMODIFYDATE NSUMMARY
   */

  /**
   * 分页查询新闻
   */
  @Override
  public List<News> queryNews(int pageSize,int currPage){
    Connection con = super.openCon();
    PreparedStatement pst = null;
    ResultSet rs = null;
    String sql = "select top " + pageSize + " NID,NTITLE,NCREATEDATE from [news] where NID not in (select top " + (currPage - 1) * pageSize + " NID from [news] )";
    List<News> list = new ArrayList<News>();
    try{
      pst = con.prepareStatement(sql);
      rs = pst.executeQuery();
      while(rs.next()){
        News news = new News();
        news.setNid(rs.getInt("NID"));
        // news.setNtid(rs.getInt("NTID"));
        news.setNtitle(rs.getString("NTITLE"));
        // news.setNauthor(rs.getString("NAUTHOR"));
        news.setNcreatedate(rs.getDate("NCREATEDATE"));
        // news.setNpicpath(rs.getString("NPICPATH"));
        // news.setNcontent(rs.getString("NCONTENT"));
        // news.setNmodifydate(rs.getDate("NMODIFYDATE"));
        // news.setNsummary(rs.getString("NSUMMARY"));
        list.add(news);
      }
    }catch(SQLException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }finally{
      super.closeAll(rs,pst,con);
    }
    return list;
  }

  /**
   * 获取新闻所有记录数
   */
  @Override
  public int getTotalCount(){
    String sql = "select count(NID) from [news]";
    int num = 0;
    Connection con = super.openCon();
    PreparedStatement pst = null;
    ResultSet rs = null;
    try{
      pst = con.prepareStatement(sql);
      rs = pst.executeQuery();
      if(rs.next()){
        num = rs.getInt(1);
      }

    }catch(SQLException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }finally{
      super.closeAll(rs,pst,con);
    }
    return num;
  }

  public static void main(String[] args){
    // NewsDao nw = new NewsDaoImp();
    // int tx = nw.getTotalCount();
    Page page = new Page();
    page.setPageSize(5);
    page.setCurrpageNo(1);
    page.setTotalCount(new NewsDaoImp().getTotalCount());
    System.out.println("当前页" + page.getCurrpageNo());
    System.out.println("每页显示记录：" + page.getPageSize());
    System.out.println("总记录数：" + page.getTotalCount());
    System.out.println("总页数：" + page.getTotalPageCount());
    List<News> list = new NewsDaoImp().queryNews(page.getPageSize(),page.getCurrpageNo());
    for(News x : list){
      System.out.println(x.getNid() + "\t" + x.getNtitle() + "\t" + x.getNcreatedate() + "\n");
    }

  }

}
