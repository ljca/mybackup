package house.servlet;

import house.biz.impl.UserBizImpl;
import house.entity.Users;
import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class LoginServlet extends HttpServlet{
  public void doGet(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{
    String path = request.getContextPath();
    PrintWriter out = response.getWriter();
    response.setContentType("text/html;charset=utf-8");
    Users users = new UserBizImpl().login(new Users(request.getParameter("uname"),request.getParameter("pwd")));
    if(null != users){
      request.getSession().setAttribute("user",users);
    // request.getRequestDispatcher("/jsp/user_home.jsp").forward(request,response);
      response.sendRedirect(path+"/jsp/user_home.jsp");
    }else{
      response.getWriter().print("<script type='text/javascript'>alert('用户名不存在！');</script>");
      response.sendRedirect(path + "/login.jsp");
    }
    out.flush();
    out.close();
    this.doPost(request,response);
  }

  public void doPost(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{
    
  }

}
