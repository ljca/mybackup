package com.yinhai.test;
public class Test1{
  public static String method(){
    return "hello world!";
  }

  public static void main(String arg[]){
    System.out.println(new Test1().method());
    System.out.println(java.lang.Math.ceil(56.66));
    System.out.println(java.lang.Math.floor(56.66 / 50.2992));
  }
}