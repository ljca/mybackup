package cn.test.servlet;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import cn.test.dao.SubWayDao;
import cn.test.entity.SubWayInfo;

public class QueryServletByID extends HttpServlet {
  public void doGet(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{

    response.setContentType("text/html;charse=utf-8");
    request.setCharacterEncoding("utf-8");
    int id = Integer.parseInt(request.getParameter("id"));
    SubWayInfo s = new SubWayDao().queryByID(id);
    request.setAttribute("s",s);
    request.getRequestDispatcher("details.jsp").forward(request,response);
  }
}
