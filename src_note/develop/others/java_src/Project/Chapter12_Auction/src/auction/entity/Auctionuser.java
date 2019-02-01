package auction.entity;

import java.util.HashSet;
import java.util.Set;

/**
 * Auctionuser entity. @author MyEclipse Persistence Tools
 */

public class Auctionuser implements java.io.Serializable{

  // Fields

  private Integer userid;

  private String username;

  private String userpassword;

  private String usercardno;

  private String usertel;

  private String useraddress;

  private String userpostnumber;

  private Boolean userisadmin;

  private String userquestion;

  private String useranswer;

  private Set auctionrecords = new HashSet(0);

  // Constructors

  /** default constructor */
  public Auctionuser(){}

  /** minimal constructor */
  public Auctionuser(Integer userid,String username,String userpassword){
    this.userid = userid;
    this.username = username;
    this.userpassword = userpassword;
  }

  /** full constructor */
  public Auctionuser(Integer userid,String username,String userpassword,String usercardno,String usertel,String useraddress,String userpostnumber,Boolean userisadmin,String userquestion,
      String useranswer,Set auctionrecords){
    this.userid = userid;
    this.username = username;
    this.userpassword = userpassword;
    this.usercardno = usercardno;
    this.usertel = usertel;
    this.useraddress = useraddress;
    this.userpostnumber = userpostnumber;
    this.userisadmin = userisadmin;
    this.userquestion = userquestion;
    this.useranswer = useranswer;
    this.auctionrecords = auctionrecords;
  }

  // Property accessors

  public Integer getUserid(){
    return this.userid;
  }

  public void setUserid(Integer userid){
    this.userid = userid;
  }

  public String getUsername(){
    return this.username;
  }

  public void setUsername(String username){
    this.username = username;
  }

  public String getUserpassword(){
    return this.userpassword;
  }

  public void setUserpassword(String userpassword){
    this.userpassword = userpassword;
  }

  public String getUsercardno(){
    return this.usercardno;
  }

  public void setUsercardno(String usercardno){
    this.usercardno = usercardno;
  }

  public String getUsertel(){
    return this.usertel;
  }

  public void setUsertel(String usertel){
    this.usertel = usertel;
  }

  public String getUseraddress(){
    return this.useraddress;
  }

  public void setUseraddress(String useraddress){
    this.useraddress = useraddress;
  }

  public String getUserpostnumber(){
    return this.userpostnumber;
  }

  public void setUserpostnumber(String userpostnumber){
    this.userpostnumber = userpostnumber;
  }

  public Boolean getUserisadmin(){
    return this.userisadmin;
  }

  public void setUserisadmin(Boolean userisadmin){
    this.userisadmin = userisadmin;
  }

  public String getUserquestion(){
    return this.userquestion;
  }

  public void setUserquestion(String userquestion){
    this.userquestion = userquestion;
  }

  public String getUseranswer(){
    return this.useranswer;
  }

  public void setUseranswer(String useranswer){
    this.useranswer = useranswer;
  }

  public Set getAuctionrecords(){
    return this.auctionrecords;
  }

  public void setAuctionrecords(Set auctionrecords){
    this.auctionrecords = auctionrecords;
  }

}