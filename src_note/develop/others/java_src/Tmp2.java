import java.util.*;
public class Tmp2{
public Map<Integer,String> map = new HashMap<Integer,String>();
map.push(1,"Java");
map.push(3,".NET");
map.push(4,"Android");
for(Integer key : map.ketSet()){
 System.out.print(map.get(key));
 }
}