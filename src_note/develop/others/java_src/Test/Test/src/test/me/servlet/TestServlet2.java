package test.me.servlet;
import java.io.IOException;
import javax.servlet.*;

public class TestServlet2 extends GenericServlet{
	/**
	 * 
	 */
	//private static final long serialVersionUID = -4948943696282235263L;

	@Override
	public void service(ServletRequest arg0, ServletResponse arg1)
			throws ServletException, IOException {
		System.out.println("");
		
	}
	
	@Override
	public void init() throws ServletException {
		super.init();
		System.out.println("");
	}

}
