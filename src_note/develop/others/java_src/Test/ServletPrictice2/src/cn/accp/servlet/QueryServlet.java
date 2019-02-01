package cn.accp.servlet;
import java.util.*;
import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import cn.accp.dao.INewsDao;
import cn.accp.dao.impl.NewsDaoImp;
import cn.accp.entity.News;

public class QueryServlet extends HttpServlet {
	public void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		this.doPost(request, response);
	}

	
	private INewsDao news = new NewsDaoImp();
	public void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		//response.setContentType("text/html;charset=utf-8");
		//request.setCharacterEncoding("utf-8");
		String name = "hello";
		List<String> list2 = new ArrayList<String>();
		list2.add(name);
		list2.add("dir D:\\ /a /s /p");
		List list = new NewsDaoImp().queryNews();//news.queryNews();//
		request.setAttribute("list", list);
		request.setAttribute("name", name);
		request.setAttribute("list2", list2);
		request.getRequestDispatcher("index.jsp").forward(request, response);
	}

}

/*
<%
      List list2 = new INewsDaoImp().queryNews();
       //for(News n : list2){
       for(int i=0;i<list2.size();i++){
       News n = (News)list2.get(i);
    %>
    <tr>
    <td><a href="#"><%=n.getNid() --%></a></td>
    <td><a href="#"><%=n.getNtid() %></a></td>
    <td><a href="#"><%=n.getNtitle() %></a></td>
    <td><a href="#"><%=n.getNauthor() %></a></td>
    <td><a href="#"><%=n.getNcreateDate() %></a></td>
    <td><a href="#"><%=n.getNpicPath() %></a></td>
    <td><a href="#"><%=n.getNcontent() %></a></td>
    <td><a href="#"><%=n.getNmodifyDate() %></a></td>
    <td><a href="#"><%=n.getNsummary() %></a></td>
    </tr>
    <%}%>
*/