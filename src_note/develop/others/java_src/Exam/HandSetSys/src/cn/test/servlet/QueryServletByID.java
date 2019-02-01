package cn.test.servlet;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import cn.test.dao.HandSetDao;
import cn.test.entity.HandSet;

public class QueryServletByID extends HttpServlet {
  public void doGet(HttpServletRequest request, HttpServletResponse response)
      throws ServletException, IOException {

    response.setContentType("text/html;charset=utf-8");
    request.setCharacterEncoding("utf-8");
    int id = Integer.parseInt(request.getParameter("id"));
    HandSet h = new HandSetDao().queryById(id);
    request.setAttribute("h", h);
    request.getRequestDispatcher("details.jsp").forward(request, response);
  }

}
