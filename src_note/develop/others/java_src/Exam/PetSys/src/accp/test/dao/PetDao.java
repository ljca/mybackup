package accp.test.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.List;

import accp.test.entity.Pet;

public class PetDao extends BaseDao {

  public List<Pet> queryPet() {
    List<Pet> petList = new ArrayList<Pet>();
    String sql = "select PET_NAME,BIRTHDAY,PET_SEX,PET_BREED from PET";
    Connection con = super.getConn();
    PreparedStatement pst = null;
    ResultSet rs = null;
    try {
      pst = con.prepareStatement(sql);
      rs = pst.executeQuery();
      while (rs.next()) {
        Pet pet = new Pet();
        pet.setPetName(rs.getString("PET_NAME"));
        pet.setBirthday(rs.getDate("BIRTHDAY"));
        pet.setPetSex(rs.getString("PET_SEX"));
        pet.setPetBreed(rs.getString("PET_BREED"));
        petList.add(pet);
      }

    } catch (SQLException e) {
      // TODO Auto-generated catch block
      e.printStackTrace();
    } finally {
      super.closeAll(rs, pst, con);
    }
    return petList;
  }

  public List<Pet> queryPetWithBreed(String breed) {
    List<Pet> petList = new ArrayList<Pet>();
    String sql = "select PET_NAME,BIRTHDAY,PET_SEX,PET_BREED from PET";
    Connection con = super.getConn();
    PreparedStatement pst = null;
    ResultSet rs = null;
    try {
      pst = con.prepareStatement(sql);
      rs = pst.executeQuery();
      while (rs.next()) {
        Pet pet = new Pet();
        pet.setPetName(rs.getString("PET_NAME"));
        pet.setBirthday(rs.getDate("BIRTHDAY"));
        pet.setPetSex(rs.getString("PET_SEX"));
        pet.setPetBreed(rs.getString("PET_BREED"));
        petList.add(pet);
      }

    } catch (SQLException e) {
      // TODO Auto-generated catch block
      e.printStackTrace();
    } finally {
      super.closeAll(rs, pst, con);
    }
    return petList;
  }

  public int addPet(Pet pt) {
    String sql = "insert into PET values(?,?,?,?,?)";
    int count = 0;
    Connection con = super.getConn();
    PreparedStatement pst = null;

    try {
      pst = con.prepareStatement(sql);
      Pet pet = new Pet();
      String birth = new SimpleDateFormat("yyyy-mm-dd").format(pet
          .getBirthday());
      pst.setString(1, pet.getPetName());
      pst.setString(3, pet.getPetBreed());
      pst.setString(2, pet.getPetSex());
      pst.setString(4, birth);
      pst.setString(5, pet.getDescription());
      count = pst.executeUpdate();
    } catch (SQLException e) {
      // TODO Auto-generated catch block
      e.printStackTrace();
    } finally {
      super.closeAll(null, pst, con);
    }
    return count;
  }
}
