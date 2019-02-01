package test.tag;

import java.io.IOException;
import java.io.StringWriter;

import javax.servlet.jsp.JspException;
import javax.servlet.jsp.JspWriter;
import javax.servlet.jsp.tagext.JspFragment;
import javax.servlet.jsp.tagext.SimpleTagSupport;

public class Hello extends SimpleTagSupport{
  @Override
  public void doTag() throws JspException,IOException{
    JspWriter out = super.getJspContext().getOut();
    out.print("hello world");
    JspFragment body= super.getJspBody();
    StringWriter writer = new StringWriter();
    body.invoke(writer);
    System.out.println(writer.toString());
    body.invoke(null);
  }
}
