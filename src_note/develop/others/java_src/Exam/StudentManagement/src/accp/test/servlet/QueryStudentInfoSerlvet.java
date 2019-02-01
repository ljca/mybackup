package accp.test.servlet;

import java.io.IOException;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import accp.test.dao.StudentDao;
import accp.test.entity.StudentInfo;

public class QueryStudentInfoSerlvet extends HttpServlet {
  public void doGet(HttpServletRequest request, HttpServletResponse response)
      throws ServletException, IOException {
    response.setContentType("text/html");
    List<StudentInfo> list = new StudentDao().queryStudentInfonfos();
    request.setAttribute("list", list);
    request.getRequestDispatcher("index.jsp").forward(request, response);
  }

}
