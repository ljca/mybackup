package accp.test.servlet;

import java.io.IOException;
import java.io.PrintWriter;
import java.text.ParseException;
import java.text.SimpleDateFormat;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import accp.test.dao.PetDao;
import accp.test.entity.Pet;

public class AddServlet extends HttpServlet {
  public void doPost(HttpServletRequest request, HttpServletResponse response)
      throws ServletException, IOException {

    response.setContentType("text/html;charset=utf-8");
    request.setCharacterEncoding("utf-8");
    PrintWriter out = response.getWriter();
    String petname = request.getParameter("nickname");
    String petsex = request.getParameter("sex");
    String petbreed = request.getParameter("breed");
    String birthday = request.getParameter("birth");
    String description = request.getParameter("description");
    Pet pet = new Pet();
    pet.setPetName(petname);
    pet.setPetBreed(petbreed);
    try {
      pet.setBirthday(new SimpleDateFormat("yyyy-MM-dd").parse(birthday));
    } catch (ParseException e) {
      // TODO Auto-generated catch block
      e.printStackTrace();
    }
    pet.setPetSex(petsex);
    pet.setDescription(description);
    int count = new PetDao().addPet(pet);
    if (count > 0) {
      out.print("<script type='text/javascript'>alert('新增宠物成功！');location.href='QueryServlet';</script>");
    } else {
      out.print("<script type='text/javascript'>alert('宠物添加失败！');</script>");
      response.sendRedirect("addPet.jsp");
    }
  }
}
