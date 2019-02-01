package product.pojo;

import java.lang.Long;
import java.util.HashSet;
import java.util.Set;

/**
 * ProductList entity. @author MyEclipse Persistence Tools
 */

public class ProductList implements java.io.Serializable{

  // Fields

  private Long id;

  private Double price;

  private String name;

  private String specification;

  private String manufacturer;

  private Set productDefailses = new HashSet(0);

  // Constructors

  /** default constructor */
  public ProductList(){}

  /** minimal constructor */
  public ProductList(Long id){
    this.id = id;
  }

  /** full constructor */
  public ProductList(Long id,Double price,String name,String specification,String manufacturer,Set productDefailses){
    this.id = id;
    this.price = price;
    this.name = name;
    this.specification = specification;
    this.manufacturer = manufacturer;
    this.productDefailses = productDefailses;
  }

  // Property accessors

  public Long getId(){
    return this.id;
  }

  public void setId(Long id){
    this.id = id;
  }

  public Double getPrice(){
    return this.price;
  }

  public void setPrice(Double price){
    this.price = price;
  }

  public String getName(){
    return this.name;
  }

  public void setName(String name){
    this.name = name;
  }

  public String getSpecification(){
    return this.specification;
  }

  public void setSpecification(String specification){
    this.specification = specification;
  }

  public String getManufacturer(){
    return this.manufacturer;
  }

  public void setManufacturer(String manufacturer){
    this.manufacturer = manufacturer;
  }

  public Set getProductDefailses(){
    return this.productDefailses;
  }

  public void setProductDefailses(Set productDefailses){
    this.productDefailses = productDefailses;
  }

}