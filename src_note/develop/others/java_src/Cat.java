class Ani{
protected String name;
public Ani(String name){
 this.name = name;
}

public void show(){
System.out.println("Ani...");

}
}

public class Cat extends Ani{
  public Cat(String name){
   super(name);
  }  

public void disp(){
System.out.println("鎴戠殑鍚嶅瓧鏄