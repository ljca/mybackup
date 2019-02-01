package cn.test.servlet;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import cn.test.dao.FeelingDao;
import cn.test.entity.Feeling;

public class QueryByIDServlet extends HttpServlet{
  public void doGet(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{
    response.setContentType("text/html;charset=utf-8");
    int id = Integer.parseInt(request.getParameter("id"));
    Feeling f = new FeelingDao().queryByID(id);
    request.setAttribute("f",f);
    request.getRequestDispatcher("detail.jsp").forward(request,response);
  }

}
