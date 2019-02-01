package cn.test.entity;

import java.util.Date;

public class Tour {
  private int tourId;
  
  private String tourCity;
  
  private String tourPlace;
  
  private Date tourTime;
  
  private String tourNote;

  public int getTourId(){
    return tourId;
  }

  public void setTourId(int tourId){
    this.tourId = tourId;
  }

  public String getTourCity(){
    return tourCity;
  }

  public void setTourCity(String tourCity){
    this.tourCity = tourCity;
  }

  public String getTourPlace(){
    return tourPlace;
  }

  public void setTourPlace(String tourPlace){
    this.tourPlace = tourPlace;
  }

  public Date getTourTime(){
    return tourTime;
  }

  public void setTourTime(Date tourTime){
    this.tourTime = tourTime;
  }

  public String getTourNote(){
    return tourNote;
  }

  public void setTourNote(String tourNote){
    this.tourNote = tourNote;
  }
  
}
