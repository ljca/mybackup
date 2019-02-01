import java.io.*;
import java.util.*;

public class ConsoleTest{

static enum Tmp{ SIZE,LENGTH }
public static void main(String[] args){
Scanner in = new Scanner(System.in);
Console console = System.console();
boolean isTrue = false;
do{
int num = 0;
System.out.println("Input a Integer Number:");
num = in.nextInt();
if(in.hasNextInt()){
  isTrue = true;
  
}else isTrue = false;
System.out.print(num);
}while(isTrue);

String uname = console.readLine("Username?");
char[] pwd = console.readPassword("Password?");
System.out.println("UserName:"+uname);

//System.out.print("Password:"+new String(pwd));
System.out.print("Password:"+String.valueOf(pwd));
pwd = null;

}
}






