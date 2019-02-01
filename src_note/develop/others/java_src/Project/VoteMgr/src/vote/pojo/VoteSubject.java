package vote.pojo;

import java.util.HashSet;
import java.util.Set;

/**
 * VoteSubject entity. @author MyEclipse Persistence Tools
 */

public class VoteSubject implements java.io.Serializable{

  // Fields

  private Short vsId;

  private String vsTitle;

  private Byte vsType;

  private Set voteOptions = new HashSet(0);

  private Set voteItems = new HashSet(0);

  // Constructors

  /** default constructor */
  public VoteSubject(){}

  /** minimal constructor */
  public VoteSubject(String vsTitle,Byte vsType){
    this.vsTitle = vsTitle;
    this.vsType = vsType;
  }

  /** full constructor */
  public VoteSubject(String vsTitle,Byte vsType,Set voteOptions,Set voteItems){
    this.vsTitle = vsTitle;
    this.vsType = vsType;
    this.voteOptions = voteOptions;
    this.voteItems = voteItems;
  }

  // Property accessors

  public Short getVsId(){
    return this.vsId;
  }

  public void setVsId(Short vsId){
    this.vsId = vsId;
  }

  public String getVsTitle(){
    return this.vsTitle;
  }

  public void setVsTitle(String vsTitle){
    this.vsTitle = vsTitle;
  }

  public Byte getVsType(){
    return this.vsType;
  }

  public void setVsType(Byte vsType){
    this.vsType = vsType;
  }

  public Set getVoteOptions(){
    return this.voteOptions;
  }

  public void setVoteOptions(Set voteOptions){
    this.voteOptions = voteOptions;
  }

  public Set getVoteItems(){
    return this.voteItems;
  }

  public void setVoteItems(Set voteItems){
    this.voteItems = voteItems;
  }

}