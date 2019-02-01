package product.pojo;

import java.lang.Long;
import java.util.Date;
import java.util.HashSet;
import java.util.Set;

/**
 * Product entity. @author MyEclipse Persistence Tools
 */

public class Product implements java.io.Serializable{

  // Fields

  private Long id;

  private String name;

  private String address;

  private Date createtime;

  private Set productDefailses = new HashSet(0);

  // Constructors

  /** default constructor */
  public Product(){}

  /** minimal constructor */
  public Product(Long id,String name,String address){
    this.id = id;
    this.name = name;
    this.address = address;
  }

  /** full constructor */
  public Product(Long id,String name,String address,Date createtime,Set productDefailses){
    this.id = id;
    this.name = name;
    this.address = address;
    this.createtime = createtime;
    this.productDefailses = productDefailses;
  }

  // Property accessors

  public Long getId(){
    return this.id;
  }

  public void setId(Long id){
    this.id = id;
  }

  public String getName(){
    return this.name;
  }

  public void setName(String name){
    this.name = name;
  }

  public String getAddress(){
    return this.address;
  }

  public void setAddress(String address){
    this.address = address;
  }

  public Date getCreatetime(){
    return this.createtime;
  }

  public void setCreatetime(Date createtime){
    this.createtime = createtime;
  }

  public Set getProductDefailses(){
    return this.productDefailses;
  }

  public void setProductDefailses(Set productDefailses){
    this.productDefailses = productDefailses;
  }

}