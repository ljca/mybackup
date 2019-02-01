package easybuy.servlet;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.List;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import easybuy.biz.ProductBiz;
import easybuy.biz.impl.ProductBizImp;
import easybuy.commons.PageBean;
import easybuy.entity.Product;

@SuppressWarnings("serial")
public class HomeServlet extends HttpServlet{
  public void doGet(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{
    response.setContentType("text/html,charset=utf-8");
    request.setCharacterEncoding("utf-8");
    String currentPage = request.getParameter("currentPage");
    Integer cp = currentPage == null || currentPage.equals("")?1:Integer.parseInt(currentPage);
    PageBean<Product> page = new ProductBizImp().loadProducts(3,cp);
    request.setAttribute("page",page);
    request.getRequestDispatcher("index.jsp").forward(request,response);
  }

  public void doPost(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{
    response.setContentType("text/html");
    PrintWriter out = response.getWriter();
    out.flush();
    out.close();
  }

  public static void main(String[] args){
    @SuppressWarnings("unused")
    PageBean<Product> page = new ProductBizImp().loadProducts(3,1);
  }
}
