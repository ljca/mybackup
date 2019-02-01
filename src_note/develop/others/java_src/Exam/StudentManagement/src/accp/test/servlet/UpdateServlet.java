package accp.test.servlet;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import accp.test.dao.StudentDao;

public class UpdateServlet extends HttpServlet {
  public void doGet(HttpServletRequest request, HttpServletResponse response)
      throws ServletException, IOException {
    response.setContentType("text/html");

  }

  @Override
  protected void doPost(HttpServletRequest request, HttpServletResponse response)
      throws ServletException, IOException {
    request.setCharacterEncoding("utf-8");
    int id = Integer.parseInt(request.getParameter("sid"));
    int count = new StudentDao().updateWithId(id);
    if (count > 0) {
      request.getRequestDispatcher("index.jsp").forward(request, response);
    } else {

    }
  }

}
