package test.me.servlet;
import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.*;

public class TestServlet implements Servlet {
@Override
public void destroy() {
	// TODO Auto-generated method stub
	
}

@Override
public ServletConfig getServletConfig() {
	// TODO Auto-generated method stub
	return null;
}

@Override
public String getServletInfo() {
	// TODO Auto-generated method stub
	return null;
}

@Override
public void init(ServletConfig arg0) throws ServletException {
	// TODO Auto-generated method stub
	System.out.println("Servlet�����ʼ��");
	
}

@Override
public void service(ServletRequest request, ServletResponse respon)
		throws ServletException, IOException {
	System.out.println("Servlet����1��ʵ��Servlet�ӿ�");
	PrintWriter out = respon.getWriter();
	out.print("���");
}

}
