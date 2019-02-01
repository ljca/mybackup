import java.io.*;
public class TestIO{
 public static void main(String[] args){
   String s = "hello";
   FileWriter fw = null;
try{
fw = new FileWriter("C:\\hello.txt");
fw.write(s);
}catch(IOException e){
e.printStackTrace();
}finally{
try{
fw.close();
}catch(IOException e){
e.printStackTrace();
}
}
 }
}