package easybuy.entity;

/**
 * 商品信息表
 * 
 * @author YL_HH_GG
 * 
 */
public class Product{

  /**
   * ep_id 编号 自动编号（标识列），从1开始，主键 ep_name 名字 ep_description 描述 ep_price 价格
   * ep_stock 库存 epc_id 分类ID epc_child_id 二级分类ID ep_file_name 文件名
   */

  private int epId;

  private String epName;

  private String epDescription;

  private Double epPrice;

  private int epStock;

  private int epcId;

  private int epcChildId;

  private String epFileName;

  public int getEpId(){
    return epId;
  }

  public void setEpId(int epId){
    this.epId = epId;
  }

  public String getEpName(){
    return epName;
  }

  public void setEpName(String epName){
    this.epName = epName;
  }

  public String getEpDescription(){
    return epDescription;
  }

  public void setEpDescription(String epDescription){
    this.epDescription = epDescription;
  }

  public Double getEpPrice(){
    return epPrice;
  }

  public void setEpPrice(Double epPrice){
    this.epPrice = epPrice;
  }

  public int getEpStock(){
    return epStock;
  }

  public void setEpStock(int epStock){
    this.epStock = epStock;
  }

  public int getEpcId(){
    return epcId;
  }

  public void setEpcId(int epcId){
    this.epcId = epcId;
  }

  public int getEpcChildId(){
    return epcChildId;
  }

  public void setEpcChildId(int epcChildId){
    this.epcChildId = epcChildId;
  }

  public String getEpFileName(){
    return epFileName;
  }

  public void setEpFileName(String epFileName){
    this.epFileName = epFileName;
  }

}
