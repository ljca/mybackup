package accp.test.entity;

import java.util.Date;

public class Pet {
  /*
   * PET_ID PET_NAME PET_BREED PET_SEX BIRTHDAY DESCRIPTION
   */

  private int petID;

  private String petName;

  private String petBreed;

  private String petSex;

  private Date birthday;

  private String description;

  public int getPetID() {
    return petID;
  }

  public void setPetID(int petID) {
    this.petID = petID;
  }

  public String getPetName() {
    return petName;
  }

  public void setPetName(String petName) {
    this.petName = petName;
  }

  public String getPetBreed() {
    return petBreed;
  }

  public void setPetBreed(String petBreed) {
    this.petBreed = petBreed;
  }

  public String getPetSex() {
    return petSex;
  }

  public void setPetSex(String petSex) {
    this.petSex = petSex;
  }

  public Date getBirthday() {
    return birthday;
  }

  public void setBirthday(Date birthday) {
    this.birthday = birthday;
  }

  public String getDescription() {
    return description;
  }

  public void setDescription(String description) {
    this.description = description;
  }

}
