package easybuy.entity;

/**
 * 用户信息表
 * 
 * @author YL_HH_GG
 * 
 */
public class User{
  /**
   * eu_user_id 用户ID eu_user_name 用户名 eu_password 密码 eu_sex 性别 eu_birthday 出生日期
   * eu_identity_code 身份证号 eu_email email eu_mobile 手机 eu_address 地址 eu_status
   * 类型 1 普通用户 2 管理员
   */
  private int euUserId;

  private String euUserName;

  private String euPassword;

  private String euSex;

  private String euBirthday;

  private int euIdentityCode;

  private String euEmail;

  private String euMobile;

  private String euAddress;

  private int euStatus;

  public int getEuUserId(){
    return euUserId;
  }

  public void setEuUserId(int euUserId){
    this.euUserId = euUserId;
  }

  public String getEuUserName(){
    return euUserName;
  }

  public void setEuUserName(String euUserName){
    this.euUserName = euUserName;
  }

  public String getEuPassword(){
    return euPassword;
  }

  public void setEuPassword(String euPassword){
    this.euPassword = euPassword;
  }

  public String getEuSex(){
    return euSex;
  }

  public void setEuSex(String euSex){
    this.euSex = euSex;
  }

  public String getEuBirthday(){
    return euBirthday;
  }

  public void setEuBirthday(String euBirthday){
    this.euBirthday = euBirthday;
  }

  public int getEuIdentityCode(){
    return euIdentityCode;
  }

  public void setEuIdentityCode(int euIdentityCode){
    this.euIdentityCode = euIdentityCode;
  }

  public String getEuEmail(){
    return euEmail;
  }

  public void setEuEmail(String euEmail){
    this.euEmail = euEmail;
  }

  public String getEuMobile(){
    return euMobile;
  }

  public void setEuMobile(String euMobile){
    this.euMobile = euMobile;
  }

  public String getEuAddress(){
    return euAddress;
  }

  public void setEuAddress(String euAddress){
    this.euAddress = euAddress;
  }

  public int getEuStatus(){
    return euStatus;
  }

  public void setEuStatus(int euStatus){
    this.euStatus = euStatus;
  }

}
