package accp.test.entity;

/*
 sid
 sname
 sgender
 sage
 saddress
 smail
 */
public class StudentInfo {
  private int sid;

  private String sname;

  private String sgender;

  private int sage;

  private String saddress;

  private String smail;

  public int getSid() {
    return sid;
  }

  public void setSid(int sid) {
    this.sid = sid;
  }

  public String getSname() {
    return sname;
  }

  public void setSname(String sname) {
    this.sname = sname;
  }

  public String getSgender() {
    return sgender;
  }

  public void setSgender(String sgender) {
    this.sgender = sgender;
  }

  public int getSage() {
    return sage;
  }

  public void setSage(int sage) {
    this.sage = sage;
  }

  public String getSaddress() {
    return saddress;
  }

  public void setSaddress(String saddress) {
    this.saddress = saddress;
  }

  public String getSmail() {
    return smail;
  }

  public void setSmail(String smail) {
    this.smail = smail;
  }

}
