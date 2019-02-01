package cn.test.entity;

public class SubWayInfo {
  /*
  ID
  SUBWAYNAME
  STARTSTATION
  ENDSTATION
  STATIONNUM
  STARTTIME
  PRICE
  */
  private int id;
  
  private String subwayName;
  
  private String startStation;
  
  private String endStation;
  
  private int stationNum;
  
  private String startTime;
  
  private int price;

  public int getId() {
    return id;
  }

  public void setId(int id) {
    this.id = id;
  }

  public String getSubwayName() {
    return subwayName;
  }

  public void setSubwayName(String subwayName) {
    this.subwayName = subwayName;
  }

  public String getStartStation() {
    return startStation;
  }

  public void setStartStation(String startStation) {
    this.startStation = startStation;
  }

  public String getEndStation() {
    return endStation;
  }

  public void setEndStation(String endStation) {
    this.endStation = endStation;
  }

  public int getStationNum() {
    return stationNum;
  }

  public void setStationNum(int stationNum) {
    this.stationNum = stationNum;
  }

  public String getStartTime() {
    return startTime;
  }

  public void setStartTime(String startTime) {
    this.startTime = startTime;
  }

  public int getPrice() {
    return price;
  }

  public void setPrice(int price) {
    this.price = price;
  }
  
}
