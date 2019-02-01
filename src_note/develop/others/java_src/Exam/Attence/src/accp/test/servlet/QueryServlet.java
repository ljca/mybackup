package accp.test.servlet;

import java.io.IOException;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import accp.test.dao.AttenceDao;
import accp.test.entity.Attence;

public class QueryServlet extends HttpServlet{
  public void doGet(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{
    response.setContentType("text/html;charset=utf-8");
    request.setCharacterEncoding("utf-8");
    List<Attence> list = new AttenceDao().queryAll();
    request.setAttribute("list",list);
    request.getRequestDispatcher("index.jsp").forward(request,response);
  }

}
