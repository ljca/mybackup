#  c#
C#问题日志

* 私有变量只能在定义它的类中被调用,不能被类之外的对象调用！
//定义类省略.....
private int sl;
public static void Main(string[] args){

* 错误！类的私有变量不能在类之外被调用
Con....(new ..().s1);
}

？为什么使用多态

？字典Dictionary<Object key,String value>以及哈希表HashTable遍历
* 键索引从0开始

？静态成员允许被实例对象调用，但是不允许访问实例成员

  
vim:set ft=markdown:
