public class ArrayTest{
 public static void main(String[] args){
  int num[][] = {{1,2},{3,4},{5,6}};
  for(int i = 0;i<num.length;i++){
   //System.out.println("浜岀淮鏁扮粍鍏冪礌"+num[i][j]);
   for(int j = 0;j<num[i].length;j++){
    //System.out.println("浜岀淮鏁扮粍鍏冪礌"+num[i][j]);
    System.out.print(num[i][j]+"  ");
   }
  }
 }

}