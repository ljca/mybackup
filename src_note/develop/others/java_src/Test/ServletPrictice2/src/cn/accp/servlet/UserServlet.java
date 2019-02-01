package cn.accp.servlet;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import cn.accp.dao.IUserDao;
import cn.accp.dao.impl.UserDaoImp;
import cn.accp.entity.Users;

public class UserServlet extends HttpServlet {

	/**
	 * Constructor of the object.
	 */
	public UserServlet() {
		super();
	}

	/**
	 * Destruction of the servlet. <br>
	 */
	public void destroy() {
		super.destroy(); // Just puts "destroy" string in log
		// Put your code here
	}

	public void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		
	}
	
	public void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		request.setCharacterEncoding("utf-8");
		response.setContentType("text/html;charset=utf-8");
		Users usr = new Users();
		IUserDao userimp = new UserDaoImp();
		String uname = request.getParameter("uname");
		String upwd = request.getParameter("upwd");
		usr.setUname(uname);
		usr.setUpwd(upwd);
		Users user = userimp.queryUser(usr);
		if(user != null){
			response.getWriter().print("<script type='text/javascript'>alert('µÇÂ¼³É¹¦£¡'); location.href='QueryServlet';</script>");
		}else{
			response.getWriter().print("<script type='text/javascript'>alert('µÇÂ¼Ê§°Ü£¡'); location.href='login.jsp';</script>");
		}
	}

	/**
	 * Initialization of the servlet. <br>
	 *
	 * @throws ServletException if an error occurs
	 */
	public void init() throws ServletException {
		// Put your code here
	}

}
