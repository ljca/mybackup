package product.pojo;

import java.lang.Long;


/**
 * ProductDefails entity. @author MyEclipse Persistence Tools
 */

public class ProductDefails  implements java.io.Serializable {


    // Fields    

     private Long id;
     private Product product;
     private ProductList productList;
     private Long amount;


    // Constructors

    /** default constructor */
    public ProductDefails() {
    }

    
    /** full constructor */
    public ProductDefails(Long id, Product product, ProductList productList, Long amount) {
        this.id = id;
        this.product = product;
        this.productList = productList;
        this.amount = amount;
    }

   
    // Property accessors

    public Long getId() {
        return this.id;
    }
    
    public void setId(Long id) {
        this.id = id;
    }

    public Product getProduct() {
        return this.product;
    }
    
    public void setProduct(Product product) {
        this.product = product;
    }

    public ProductList getProductList() {
        return this.productList;
    }
    
    public void setProductList(ProductList productList) {
        this.productList = productList;
    }

    public Long getAmount() {
        return this.amount;
    }
    
    public void setAmount(Long amount) {
        this.amount = amount;
    }
   








}