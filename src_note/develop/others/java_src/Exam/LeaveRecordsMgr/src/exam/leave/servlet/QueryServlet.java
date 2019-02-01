package exam.leave.servlet;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.List;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import exam.leave.dao.ILeaveRecordsDao;
import exam.leave.dao.impl.LeaveRecordsDaoImp;
import exam.leave.entity.LeaveRecords;

public class QueryServlet extends HttpServlet{
  private ILeaveRecordsDao tmp = new LeaveRecordsDaoImp();

  public void doGet(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{

    response.setContentType("text/html;charset=utf-8");
    request.setCharacterEncoding("utf-8");
    List<LeaveRecords> leave = tmp.loadAllRecords();
    if(null != leave){
      request.setAttribute("leave",leave);
      request.getRequestDispatcher("index.jsp").forward(request,response);
    }
  }

  public void doPost(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{

    response.setContentType("text/html");
  }

}
