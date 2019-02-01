package easybuy.entity;

/**
 * 商品分类表
 * 
 * @author YL_HH_GG
 * 
 */
public class ProductCategory{
  /*
   * epc_id 编号 自动编号（标识列），从1开始，主键 epc_name 名字 epc_parent_id 父分类
   */

  private int epcId;

  private String epcNameString;

  private String epcParentId;

  public int getEpcId(){
    return epcId;
  }

  public void setEpcId(int epcId){
    this.epcId = epcId;
  }

  public String getEpcNameString(){
    return epcNameString;
  }

  public void setEpcNameString(String epcNameString){
    this.epcNameString = epcNameString;
  }

  public String getEpcParentId(){
    return epcParentId;
  }

  public void setEpcParentId(String epcParentId){
    this.epcParentId = epcParentId;
  }

}
