package easybuy.tag;
import java.io.IOException;
import java.util.List;
import javax.servlet.jsp.JspException;
import javax.servlet.jsp.JspWriter;
import javax.servlet.jsp.tagext.SimpleTagSupport;
import easybuy.commons.PageBean;
import easybuy.entity.Product;

public class PageTag extends SimpleTagSupport{
  private String path;

  private PageBean page;

  public String getPath(){
    return path;
  }

  public void setPath(String path){
    this.path = path;
  }

  public PageBean getPage(){
    return page;
  }

  public void setPage(PageBean page){
    this.page = page;
  }

  @Override
  public void doTag() throws JspException,IOException{
    StringBuffer htmlBuffer = new StringBuffer();
    htmlBuffer.append("<a href='")
    .append(path)
    .append("?currentPage=1'>首页</a>&nbsp;&nbsp;");

    if(page.getHasPre()){
      htmlBuffer.append("<a href='")
      .append(path)
      .append("?currentPage=")
      .append(page.getPageSize()-1)
      .append("'>上一页</a>&nbsp;&nbsp;");
    }else {
      htmlBuffer.append("上一页&nbsp;&nbsp;");
    }

    if(page.getHasPre()){
      htmlBuffer.append("<a href='")
      .append(path)
      .append("?currentPage=")
      .append(page.getPageSize()+1)
      .append("'>下一页</a>&nbsp;&nbsp;");
    }else {
      htmlBuffer.append("下一页&nbsp;&nbsp;");
    }
    htmlBuffer.append("<a href='")
    .append(path)
    .append("?currentPage=")
    .append(page.getTotalPage())
    .append("'>末页</a>&nbsp;&nbsp;");
    JspWriter out = super.getJspContext().getOut();
    out.write(htmlBuffer.toString());
  }
  
}