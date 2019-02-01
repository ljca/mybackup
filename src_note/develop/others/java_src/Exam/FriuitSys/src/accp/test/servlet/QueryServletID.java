package accp.test.servlet;
import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import accp.test.dao.FruitDao;
import accp.test.entity.Fruit;

public class QueryServletID extends HttpServlet {
  public void doGet(HttpServletRequest request, HttpServletResponse response)
      throws ServletException, IOException {
    request.setCharacterEncoding("utf-8");
    response.setContentType("text/html;charset=utf-8");
    String id = request.getParameter("id");
    Fruit f = new FruitDao().queryFruitsWithID(Integer.parseInt(id));
    request.setAttribute("f", f);
    request.getRequestDispatcher("fruitBrice.jsp").forward(request,response);
  }
  
  
}
