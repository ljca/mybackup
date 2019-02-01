package auction.security;

import java.util.Scanner;

public class Test{
  public static void main(String[] args){
    String pwd = MD5.md5crypt("tmp");
    System.out.println(pwd);
    Scanner in = new Scanner(System.in);
    String ll = in.next();
    String tmp = MD5.md5crypt(ll);
    if(tmp == pwd){
      System.out.println("密码验证成功！");
      in.close();
    }
  }
  
}
