package easybuy.entity;

/**
 * 单明细表
 * 
 * @author YL_HH_GG
 * 
 */
public class OrderDetail{
  /*
   * eod_id 编号 自动编号（标识列），从1开始，主键 eo_id 订单ID ep_id 商品ID eod_quantity 数量 eod_cost
   * 金额
   */
  private int eodId;

  private int eoId;

  private int epId;

  private int eodQuantity;

  private int eodCost;

  public int getEodId(){
    return eodId;
  }

  public void setEodId(int eodId){
    this.eodId = eodId;
  }

  public int getEoId(){
    return eoId;
  }

  public void setEoId(int eoId){
    this.eoId = eoId;
  }

  public int getEpId(){
    return epId;
  }

  public void setEpId(int epId){
    this.epId = epId;
  }

  public int getEodQuantity(){
    return eodQuantity;
  }

  public void setEodQuantity(int eodQuantity){
    this.eodQuantity = eodQuantity;
  }

  public int getEodCost(){
    return eodCost;
  }

  public void setEodCost(int eodCost){
    this.eodCost = eodCost;
  }

}
