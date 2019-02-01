package cn.test.servlet;

import java.io.IOException;
import java.io.PrintWriter;
import java.text.ParseException;
import java.text.SimpleDateFormat;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import cn.test.dao.TourDao;
import cn.test.entity.Tour;

public class AddServlet extends HttpServlet {
  public void doGet(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{

    response.setContentType("text/html");
    this.doPost(request,response);
  }

  public void doPost(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{

    response.setContentType("text/html;charset=utf-8");
    request.setCharacterEncoding("utf-8");
    PrintWriter out = response.getWriter();
    Tour t = new Tour();
    t.setTourCity(request.getParameter("city"));
    t.setTourPlace(request.getParameter("place"));
    try{
      t.setTourTime(new SimpleDateFormat("yyyy-MM-dd").parse(request.getParameter("time")));
    }catch(ParseException e){
      // TODO 自动生成的 catch 块
      e.printStackTrace();
    }
    t.setTourNote(request.getParameter("note"));
    if(new TourDao().addTour(t) > 0){
      out.print("<script type='text/javascript'>alert('添加成功！');location.href='QueryServlet'</script>");
    }else {
      out.print("<script type='text/javascript'>alert('添加失败！重新添加');location.href='addTour.jsp'</script>"); 
    }
    out.flush();
    out.close();
  }

}
