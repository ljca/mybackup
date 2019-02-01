package cn.test.entity;

public class HandSet {
  
  /*
  HS_ID
  NAME_TYPE
  PRICE
  NETWORK_MODE
  NETWORK_TYPE
  FACADE
  SCREEN_SIZE
  FEEL_SCREEN
 */
  
  
  private int hsID;
  
  private String nameType;
  
  private int price;
  
  private String networkMode;
  
  private String networkType;
  
  private String facade;
  
  private String screenSize;
  
  private String feelScreen;

  public int getHsID() {
    return hsID;
  }

  public void setHsID(int hsID) {
    this.hsID = hsID;
  }

  public String getNameType() {
    return nameType;
  }

  public void setNameType(String nameType) {
    this.nameType = nameType;
  }

  public int getPrice() {
    return price;
  }

  public void setPrice(int price) {
    this.price = price;
  }

  public String getNetworkMode() {
    return networkMode;
  }

  public void setNetworkMode(String networkMode) {
    this.networkMode = networkMode;
  }

  public String getNetworkType() {
    return networkType;
  }

  public void setNetworkType(String networkType) {
    this.networkType = networkType;
  }

  public String getFacade() {
    return facade;
  }

  public void setFacade(String facade) {
    this.facade = facade;
  }

  public String getScreenSize() {
    return screenSize;
  }

  public void setScreenSize(String screenSize) {
    this.screenSize = screenSize;
  }

  public String getFeelScreen() {
    return feelScreen;
  }

  public void setFeelScreen(String feelScreen) {
    this.feelScreen = feelScreen;
  }
  
}
