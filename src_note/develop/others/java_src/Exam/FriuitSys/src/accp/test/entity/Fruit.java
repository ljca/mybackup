package accp.test.entity;

public class Fruit {
  /*
   * FRUIT_ID TYPE BREED AREA BRICE WEIGHT PRICE
   */

  private int fruitID; //水果编号
 
  private String type; //水果类型
 
  private String breed; //水果品种

  private String area; //水果产地

  private String brice; //水果描述

  private int weight; //水果重量

  private double price; //水果单价

  public int getFruitID() {
    return fruitID;
  }

  public void setFruitID(int fruitID) {
    this.fruitID = fruitID;
  }

  public String getType() {
    return type;
  }

  public void setType(String type) {
    this.type = type;
  }

  public String getBreed() {
    return breed;
  }

  public void setBreed(String breed) {
    this.breed = breed;
  }

  public String getArea() {
    return area;
  }

  public void setArea(String area) {
    this.area = area;
  }

  public String getBrice() {
    return brice;
  }

  public void setBrice(String brice) {
    this.brice = brice;
  }

  public int getWeight() {
    return weight;
  }

  public void setWeight(int weight) {
    this.weight = weight;
  }

  public double getPrice() {
    return price;
  }

  public void setPrice(double price) {
    this.price = price;
  }

}
