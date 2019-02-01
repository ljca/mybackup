package accp.test.servlet;

import java.io.IOException;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import accp.test.dao.FruitDao;
import accp.test.entity.Fruit;

public class QueryServlet extends HttpServlet {
  public void doGet(HttpServletRequest request, HttpServletResponse response)
      throws ServletException, IOException {
    request.setCharacterEncoding("utf-8");
    response.setContentType("text/html");

    List<Fruit> list = new FruitDao().queryFruits();
    request.setAttribute("list", list);
    request.getRequestDispatcher("index.jsp").forward(request, response);
  }
  
}
