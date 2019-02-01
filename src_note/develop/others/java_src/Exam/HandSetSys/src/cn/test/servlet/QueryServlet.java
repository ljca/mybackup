package cn.test.servlet;

import java.io.IOException;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import cn.test.dao.HandSetDao;
import cn.test.entity.HandSet;

public class QueryServlet extends HttpServlet {
  public void doGet(HttpServletRequest request, HttpServletResponse response)
      throws ServletException, IOException {

    response.setContentType("text/html;charset=utf-8");
    request.setCharacterEncoding("utf-8");
    List<HandSet> list = new HandSetDao().queryAll();
    request.setAttribute("list", list);
    request.getRequestDispatcher("index.jsp").forward(request, response);
  }

}
