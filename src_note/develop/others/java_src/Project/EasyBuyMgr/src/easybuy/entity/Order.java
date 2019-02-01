package easybuy.entity;

import java.util.Date;

/**
 * 订单表
 * 
 * @author YL_HH_GG
 * 
 */
public class Order{

  /*
   * eo_id 编号 自动编号（标识列），从1开始，主键 eo_user_id 用户ID eo_user_name 用户名 eo_user_address
   * 用户地址 eo_create_time 创建时间 eo_cost 金额 eo_status 状态 1 下单 2 审核通过 3 配货 4 送货中
   * 5收获并确认 eo_type 付款方式 1 货到付款 2 网上支付
   */

  private int eoId;

  private int eoUserId;

  private String eoUserName;

  private String eoUserAddress;

  private Date eoCreateTime;

  private Double eoCost;

  private int eoStatus;

  private int eoType;

  public int getEoId(){
    return eoId;
  }

  public void setEoId(int eoId){
    this.eoId = eoId;
  }

  public int getEoUserId(){
    return eoUserId;
  }

  public void setEoUserId(int eoUserId){
    this.eoUserId = eoUserId;
  }

  public String getEoUserName(){
    return eoUserName;
  }

  public void setEoUserName(String eoUserName){
    this.eoUserName = eoUserName;
  }

  public String getEoUserAddress(){
    return eoUserAddress;
  }

  public void setEoUserAddress(String eoUserAddress){
    this.eoUserAddress = eoUserAddress;
  }

  public Date getEoCreateTime(){
    return eoCreateTime;
  }

  public void setEoCreateTime(Date eoCreateTime){
    this.eoCreateTime = eoCreateTime;
  }

  public Double getEoCost(){
    return eoCost;
  }

  public void setEoCost(Double eoCost){
    this.eoCost = eoCost;
  }

  public int getEoStatus(){
    return eoStatus;
  }

  public void setEoStatus(int eoStatus){
    this.eoStatus = eoStatus;
  }

  public int getEoType(){
    return eoType;
  }

  public void setEoType(int eoType){
    this.eoType = eoType;
  }

}
