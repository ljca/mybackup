package vote.pojo;

import java.util.HashSet;
import java.util.Set;

/**
 * VoteUser entity. @author MyEclipse Persistence Tools
 */

public class VoteUser implements java.io.Serializable{

  // Fields

  private String vuUserId;

  private String vuUserName;

  private String vuPassword;

  private Set voteItems = new HashSet(0);

  // Constructors

  /** default constructor */
  public VoteUser(){}

  /** minimal constructor */
  public VoteUser(String vuUserName,String vuPassword){
    this.vuUserName = vuUserName;
    this.vuPassword = vuPassword;
  }

  /** full constructor */
  public VoteUser(String vuUserName,String vuPassword,Set voteItems){
    this.vuUserName = vuUserName;
    this.vuPassword = vuPassword;
    this.voteItems = voteItems;
  }

  // Property accessors

  public String getVuUserId(){
    return this.vuUserId;
  }

  public void setVuUserId(String vuUserId){
    this.vuUserId = vuUserId;
  }

  public String getVuUserName(){
    return this.vuUserName;
  }

  public void setVuUserName(String vuUserName){
    this.vuUserName = vuUserName;
  }

  public String getVuPassword(){
    return this.vuPassword;
  }

  public void setVuPassword(String vuPassword){
    this.vuPassword = vuPassword;
  }

  public Set getVoteItems(){
    return this.voteItems;
  }

  public void setVoteItems(Set voteItems){
    this.voteItems = voteItems;
  }

}