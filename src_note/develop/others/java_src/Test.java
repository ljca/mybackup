//Person.java
class Person {
	protected String name;
	public void study(String name){
		this.name=name;
		System.out.println(this.name+"姝ｅ湪瀛︿範");
	}
}
//Student.java
class Student extends Person{
	public void study(String name){
		super.name=name;
		System.out.println("瀛︾敓"+super.name+"姝ｅ湪瀛︿範");
	}
}
//Test.java 
public class Test {
	public static void main(String[] args) {
		Person p = new Student();
		p.study("鏉庣珛");		
	}
}