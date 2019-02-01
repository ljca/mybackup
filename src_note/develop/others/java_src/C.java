interface A{int x =0 ;}
class B{int x =1;}
public class C extends B implements A{
public void Px(){
System.out.println(super.x);
}
  public static void main(String[] args){
new C().Px();
  }
}