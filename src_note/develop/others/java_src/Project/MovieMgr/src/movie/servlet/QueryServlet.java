package movie.servlet;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.List;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import movie.biz.impl.MovieBizImp;
import movie.entity.Movie;

@SuppressWarnings("serial")
public class QueryServlet extends HttpServlet{
  public void doGet(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{
    response.setContentType("text/html,charset=utf-8");
    //List<Movie> list = new MovieBizImp().queryAllMovies();
    //request.setAttribute("list",list);
    request.getRequestDispatcher("index.jsp").forward(request,response);
  }

  public void doPost(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{
    response.setContentType("text/html");
    PrintWriter out = response.getWriter();

    out.flush();
    out.close();
  }

}
