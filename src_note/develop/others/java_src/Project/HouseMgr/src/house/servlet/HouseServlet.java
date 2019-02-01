package house.servlet;

import house.biz.impl.HouseBizImp;
import house.dao.impl.HouseDaoImpl;
import house.entity.House;
import house.page.support.PageUtil;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.List;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class HouseServlet extends HttpServlet{
  public void doGet(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{

    response.setContentType("text/html");
    request.setCharacterEncoding("utf-8");
    //List<House> list = (new HouseBizImp().queryAllHouse()).getList();
    PageUtil page = new HouseBizImp().queryAllHouse();
    if(null != page){
      request.setAttribute("page",page);
      request.getRequestDispatcher("index.jsp").forward(request,response);
    }else {
      System.out.println("空指针异常！");
      request.getRequestDispatcher("login.jsp").forward(request,response);
    }
  }

  public void doPost(HttpServletRequest request,HttpServletResponse response) throws ServletException,IOException{

    response.setContentType("text/html");
    PrintWriter out = response.getWriter();
    out.flush();
    out.close();
  }
  @SuppressWarnings({"unused","unchecked"})
  public static void main(String[] args){
    List<House> list = (new HouseBizImp().queryAllHouse()).getList();
    for(House house : list){
      System.out.println(house.getTitle()+"  "+ house.getPrice());
    }
  }
  
}
