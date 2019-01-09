<?php
#$xml = new DOMDocument();
#$xml->load("persion.xml");

#print $xml->saveXML();
#
/*
$child = $xml->documentElement;

foreach($child->childNodes AS $item){
  echo $item->nodeName," = ",$item->nodeValue;
  echo "<br>";
}
 */

# simple xml parse

$xml = simplexml_load_file("persion.xml");
var_dump($xml);
echo "<br>";
print_r($xml);
echo "<br>";
echo "$xml->to","<br>";
echo "$xml->from","<br>";
echo "$xml->heading","<br>";
echo "$xml->body","<br>";

echo "root element: ",$xml->getName(),"<br>";
foreach($xml->children() as $child){
  echo $child->getName(),": ",$child,"<br>";
}

?>
