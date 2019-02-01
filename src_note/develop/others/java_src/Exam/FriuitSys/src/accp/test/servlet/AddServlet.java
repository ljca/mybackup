package accp.test.servlet;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import accp.test.dao.FruitDao;
import accp.test.entity.Fruit;

public class AddServlet extends HttpServlet {
  @Override
  protected void doGet(HttpServletRequest request, HttpServletResponse response)
      throws ServletException, IOException {
    // TODO Auto-generated method stub
    this.doPost(request, response);
  }
  public void doPost(HttpServletRequest request, HttpServletResponse response)
      throws ServletException, IOException {
    response.setContentType("text/html;charset=utf-8");
    request.setCharacterEncoding("utf-8");
    PrintWriter out = response.getWriter();
    Fruit f = new Fruit();
    f.setType(request.getParameter("tye"));
    f.setBreed(request.getParameter("breed"));
    f.setArea(request.getParameter("area"));
    f.setBrice(request.getParameter("brice"));
    f.setWeight(Integer.parseInt(request.getParameter("weights")));
    f.setPrice(Double.parseDouble(request.getParameter("price")));
    if (new FruitDao().addFruit(f) > 0) {
      out.print("<script type='text/javascript'>alert('添加成功！');location.href='QueryServlet'</script>");
    }else {
      out.print("<script type='text/javascript'>alert('添加失败！');");
      response.sendRedirect("addFruit.jsp");
    }
    
    out.flush();
    out.close();
  }

}
