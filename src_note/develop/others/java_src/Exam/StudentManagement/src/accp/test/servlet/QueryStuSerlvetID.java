package accp.test.servlet;

import java.io.IOException;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import accp.test.dao.StudentDao;
import accp.test.entity.StudentInfo;

public class QueryStuSerlvetID extends HttpServlet {
  private static final long serialVersionUID = 1L;

  public void doGet(HttpServletRequest request, HttpServletResponse response)
      throws ServletException, IOException {
    response.setContentType("text/html");
    int id = Integer.parseInt(request.getParameter("sid"));
    List<StudentInfo> list2 = new StudentDao().queryWithId(id);
    request.setAttribute("list2", list2);
    request.getRequestDispatcher("index.jsp").forward(request, response);
  }

}
