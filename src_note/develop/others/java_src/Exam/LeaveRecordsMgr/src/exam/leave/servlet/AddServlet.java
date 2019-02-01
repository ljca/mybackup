package exam.leave.servlet;

import java.io.IOException;
import java.io.PrintWriter;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import exam.leave.dao.ILeaveRecordsDao;
import exam.leave.dao.impl.LeaveRecordsDaoImp;
import exam.leave.entity.LeaveRecords;

public class AddServlet extends HttpServlet{

  /**
   * 
   */
  private static final long serialVersionUID = 1L;
  private ILeaveRecordsDao tmp = new LeaveRecordsDaoImp();

  public void doGet(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{
    doPost(request,response);
  }

  public void doPost(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{

    response.setContentType("text/html;charset=utf-8");
    request.setCharacterEncoding("utf-8");
    PrintWriter out = response.getWriter();
    LeaveRecords leaveRecords = new LeaveRecords();
    leaveRecords.setName(request.getParameter("name"));
    try{
      leaveRecords.setTime(new SimpleDateFormat("yyyy-MM-dd").parse(request.getParameter("time")));
    }catch(ParseException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }
    leaveRecords.setReason(request.getParameter("reason"));

    if(null != tmp){
      if(tmp.addRecords(leaveRecords) != 0){
      out.print("<script type='text/javascript'>alert('添加成功！');location.href='QueryServlet';</script>");
        //response.sendRedirect("QueryServlet");
      }else{
        out.print("<script type='text/javascript'>alert('添加失败！');location.back();</script>");
      }
    }

    out.flush();
    out.close();
  }

}
