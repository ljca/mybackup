package house.dao.impl;
import house.entity.District;
import house.entity.Users;
import java.util.List;
import org.hibernate.Query;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;

public class OracleDao{
  @SuppressWarnings("unchecked")
  public static void queryDistricts(){
    /* List<District> list = new ArrayList<District>(); */
    Configuration config = new Configuration().configure();
    SessionFactory sf = config.buildSessionFactory();
    Session session = sf.openSession();
    String hql = "from District";
    Query query = session.createQuery(hql);
    List<District> list = (List<District>) query.list();
    System.out.println("城区ID" + "\t" + "城区名称");
    for(District district : list){
      System.out.println(district.getId() + "\t" + district.getName());
    }
    List<Users> listuser = (List<Users>) session.createQuery("from Users").list();
    for(Users users : listuser){
      System.out.println(users.getId() + "\t" + users.getName() + "\t" + users.getUserName());
    }
    District ds = (District) session.get(District.class,new Integer(3));
    System.out.println("城区ID" + "\t" + "城区名称");
    System.out.println(ds.getId() + "\t" + ds.getName());
    if(null != session){
      session.close();
      session = null;
    }
  }

  public static void main(String[] args){
    // con = openConnection();
    // closeCon();
    queryDistricts();
  }
}
