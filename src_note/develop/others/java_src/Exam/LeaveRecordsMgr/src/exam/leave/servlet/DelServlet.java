package exam.leave.servlet;

import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import exam.leave.dao.ILeaveRecordsDao;
import exam.leave.dao.impl.LeaveRecordsDaoImp;

public class DelServlet extends HttpServlet{
  private ILeaveRecordsDao leveDao = new LeaveRecordsDaoImp();

  public void doGet(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{

    response.setContentType("text/html;charset=utf-8");
    request.setCharacterEncoding("utf-8");
    PrintWriter out = response.getWriter();
    Integer id = Integer.parseInt(request.getParameter("id"));
    if(null != id){
      if(leveDao.delRecords(id) != 0){
        response.sendRedirect("QueryServlet");
      }
    }else {
      out.print("<script type='text/javascript'>alert('失败！');location.back();</script>");
    }
    out.flush();
    out.close();
  }

  public void doPost(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{

    response.setContentType("text/html");
    PrintWriter out = response.getWriter();
    out.flush();
    out.close();
  }

}
