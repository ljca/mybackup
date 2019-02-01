package accp.test.servlet;

import java.io.IOException;
import java.io.PrintWriter;
import java.text.ParseException;
import java.text.SimpleDateFormat;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import accp.test.dao.AttenceDao;
import accp.test.entity.Attence;

public class AddServlet extends HttpServlet{

  @Override
  protected void doGet(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{
    // TODO Auto-generated method stub
    this.doPost(request,response);
  }

  public void doPost(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{
    response.setContentType("text/html;charset=utf-8");
    request.setCharacterEncoding("utf-8");
    PrintWriter out = response.getWriter();
    Attence a = new Attence();
    a.setEmpName(request.getParameter("name"));
    a.setDept(request.getParameter("dept"));
    try{
      a.setChkDate(new SimpleDateFormat().parse(request.getParameter("chkdate")));
    }catch(ParseException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }
    a.setStatus(request.getParameter("state"));
    if(new AttenceDao().addEmp(a) > 0){
      out.print("<script type='text/javascript'>alert('考勤登记成功！');location.href='QueryServlet'</script>");
    }else{
      out.print("<script type='text/javascript'>alert('考勤登记失败！');</script>");
      response.sendRedirect("addAttence.jsp");
    }
    out.flush();
    out.close();
  }

}
