package test.servlet;

import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class AjaxServlet extends HttpServlet{
  public void doGet(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{
    this.doPost(request,response);
  }

  public void doPost(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{
    response.setContentType("text/html;charset=utf-8");
    PrintWriter out = response.getWriter();
    // out.print("hello,Ajax");
    System.out.println("Hello,Ajax!");
    String uname = request.getParameter("uname");
    if(null != uname || uname != ""){
      if(uname.equals("admin")){
        out.print("<script type='text/javascript'>alert('用户名已被使用！');</script>");
      }else{
      out.print("<script type='text/javascript'>alert('用户名可以使用！');</script>");
      }
    }else{
        out.print("<script type='text/javascript'>alert('用户名为空！');</script>");
    
    }
    out.flush();
    out.close();
  }
}
