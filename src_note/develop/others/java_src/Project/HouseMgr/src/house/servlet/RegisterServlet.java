package house.servlet;

import house.biz.impl.UserBizImpl;
import house.entity.Users;
import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class RegisterServlet extends HttpServlet{
  public void doGet(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{

    response.setContentType("text/html");
    this.doPost(request,response);
  }

  public void doPost(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{
    response.setContentType("text/html;charset=utf-8");
    PrintWriter out = response.getWriter();
    
    Users user = new Users(request.getParameter("uname"),request.getParameter("pwd"));
    if(null != new UserBizImpl().regester(user)){
      out.print("<script type='text/javascript'>alert('注册成功！');</script>");
      request.getSession().setAttribute("user",user);response.sendRedirect("/jsp/usr_home.jsp");
    }else{
      out.print("<script type='text/javascript'>alert('用户名已存在！');location.href='/jsp/register.jsp'</script>");
    }
    out.flush();
    out.close();
  }

}
