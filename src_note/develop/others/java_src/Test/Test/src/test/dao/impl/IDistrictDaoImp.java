package test.dao.impl;

import java.io.IOException;
import java.io.Reader;
import java.util.List;
import org.apache.ibatis.io.Resources;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.apache.ibatis.session.SqlSessionFactoryBuilder;
import test.dao.IDistrictDao;
import test.entity.District;

public class IDistrictDaoImp implements IDistrictDao{

  @Override
  public int countAll(){
    SqlSession sqlSession = null;
    SqlSessionFactory sqlsf = null;
    Reader reader = null;
    int count = 0;
    try{
      reader = Resources.getResourceAsReader("mybatis-config.xml");
      sqlsf = new SqlSessionFactoryBuilder().build(reader);
      sqlSession = sqlsf.openSession();
      count = sqlSession.selectOne("test.dao.IDistrictDao.countAll");

    }catch(IOException e){
      e.printStackTrace();
    }finally{
      if(null != sqlSession){
        sqlSession.close();
      }
    }
    return count;
  }

  @Override
  public void queryDistrict(){
    SqlSession sqlSession = null;
    SqlSessionFactory sqlsf = null;
    Reader reader = null;
    try{
      reader = Resources.getResourceAsReader("mybatis-config.xml");
      sqlsf = new SqlSessionFactoryBuilder().build(reader);
      sqlSession = sqlsf.openSession();
      List<District> list = sqlSession.selectList("test.dao.IDistrictDao.queryDistrict");
      for(District district : list){
        System.out.println(district.getName() + "\t" + district.getId());
      }
    }catch(IOException e){
      e.printStackTrace();
    }finally{
      if(null != sqlSession){
        sqlSession.close();
      }
    }
  }

  public static void main(String[] args){
    // System.out.println(new IDistrictDaoImp().countAll());
    new IDistrictDaoImp().queryDistrict();
  }

}
