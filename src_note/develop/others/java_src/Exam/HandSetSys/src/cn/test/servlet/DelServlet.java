package cn.test.servlet;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import cn.test.dao.HandSetDao;

public class DelServlet extends HttpServlet {
  public void doGet(HttpServletRequest request, HttpServletResponse response)
      throws ServletException, IOException {

    response.setContentType("text/html;charset=utf-8");
    request.setCharacterEncoding("utf-8");
    int id = Integer.parseInt(request.getParameter("id"));
    PrintWriter out = response.getWriter();
    if (new HandSetDao().delHand(id) > 0) {
      out.print("<script type='text/javascript'>alert('删除成功！');location.href='QueryServlet'</script>");
    }else {
      out.print("<script type='text/javascript'>alert('删除成功！');location.href='QueryServlet'</script>");
    }
    out.flush();
    out.close();
  }

}
