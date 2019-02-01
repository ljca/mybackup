package cn.test.servlet;

import java.io.IOException;
import java.io.PrintWriter;
import java.text.ParseException;
import java.text.SimpleDateFormat;

import javax.persistence.criteria.CriteriaBuilder.In;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import cn.test.dao.FeelingDao;
import cn.test.entity.Feeling;

public class AddServlet extends HttpServlet{
  public void doPost(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{
    response.setContentType("text/html;chaset=utf-8");
    request.setCharacterEncoding("utf-8");
    PrintWriter out = response.getWriter();
    Feeling f = new Feeling();
    f.setFtitle(request.getParameter("title"));
    f.setFcontent(request.getParameter("content"));
    try{
      f.setFdate(new SimpleDateFormat("yyyy-MM-dd").parse(request.getParameter("date")));
    }catch(ParseException e){
      // TODO Auto-generated catch block
      e.printStackTrace();
    }
    int type = Integer.parseInt(request.getParameter("type"));
    f.setFtype(type);
    if(new FeelingDao().add(f) > 0){
      out.print("<script type='text/javascript'>alert('记录心情成功！');location.href='QueryServlet'</script>");
    }else {
      out.print("<script type='text/javascript'>alert('记录心情失败！');location.href='add.jsp'</script>");
    }
    out.flush();
    out.close();
  }

}
