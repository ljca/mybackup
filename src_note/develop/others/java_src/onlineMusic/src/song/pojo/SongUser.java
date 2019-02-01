package song.pojo;
import java.util.*;

/**
 *@author kyzs
 *@date 
 *@version 1.0
 */
public class SongUser{
/** **/
private Integer id;
/** **/
private String user;
/** id,用户类型。1可作为管理员，否则属于普通用户 **/
private Integer userType;
/** **/
private String userPsk;
/** **/
public void setId(Integer id){ this.id=id;}
/** **/
public Integer getId(){return this.id;}
/** **/
public void setUser(String uname){this.user=uname;}
/** **/
public String getUser(){return this.user;}
/** **/
public void setUserType(Integer uType){this.userType=uType;}
/** **/
public Integer getUserType(){return this.userType;}
/** **/
public void setUserPsk(String psk){this.userPsk=psk;}
/** **/
public String getUserPsk(){return this.userPsk;}

}
