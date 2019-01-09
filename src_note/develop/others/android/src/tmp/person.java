public class person{
	native void test();
	static{
		System.loadLibrary("person");
	}
	public static void main(String args[]){
		new person().test();
		//System.out.println("hello");
	}
}
