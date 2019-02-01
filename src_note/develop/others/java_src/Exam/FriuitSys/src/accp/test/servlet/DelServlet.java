package accp.test.servlet;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import accp.test.dao.FruitDao;

public class DelServlet extends HttpServlet {
  public void doGet(HttpServletRequest request, HttpServletResponse response)
      throws ServletException, IOException {

    response.setContentType("text/html;charset=utf-8");
    request.setCharacterEncoding("utf-8");
    PrintWriter out = response.getWriter();
    int id = Integer.parseInt(request.getParameter("id"));
    int i = new FruitDao().delFruit(id);
    if (i != 0) {
      out.print("<script type='text/javascript'>alert('删除成功！');location.href='QueryServlet';</script>");
    } else {
      out.print("<script type='text/javascript'>alert('删除失败！');location.href='QueryServlet';</script>");
    }
    out.flush();
    out.close();
  }

}
