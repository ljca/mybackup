package vote.pojo;

import java.util.HashSet;
import java.util.Set;

/**
 * VoteOption entity. @author MyEclipse Persistence Tools
 */

public class VoteOption implements java.io.Serializable{

  // Fields

  private Short voId;

  private VoteSubject voteSubject;

  private String voOption;

  private Short voOrder;

  private Set voteItems = new HashSet(0);

  // Constructors

  /** default constructor */
  public VoteOption(){}

  /** minimal constructor */
  public VoteOption(VoteSubject voteSubject,String voOption){
    this.voteSubject = voteSubject;
    this.voOption = voOption;
  }

  /** full constructor */
  public VoteOption(VoteSubject voteSubject,String voOption,Short voOrder,Set voteItems){
    this.voteSubject = voteSubject;
    this.voOption = voOption;
    this.voOrder = voOrder;
    this.voteItems = voteItems;
  }

  // Property accessors

  public Short getVoId(){
    return this.voId;
  }

  public void setVoId(Short voId){
    this.voId = voId;
  }

  public VoteSubject getVoteSubject(){
    return this.voteSubject;
  }

  public void setVoteSubject(VoteSubject voteSubject){
    this.voteSubject = voteSubject;
  }

  public String getVoOption(){
    return this.voOption;
  }

  public void setVoOption(String voOption){
    this.voOption = voOption;
  }

  public Short getVoOrder(){
    return this.voOrder;
  }

  public void setVoOrder(Short voOrder){
    this.voOrder = voOrder;
  }

  public Set getVoteItems(){
    return this.voteItems;
  }

  public void setVoteItems(Set voteItems){
    this.voteItems = voteItems;
  }

}