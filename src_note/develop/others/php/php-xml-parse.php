<?php 
var_dump($xml=xml_parser_create());
echo "</br>";

function start($xml,$name,$attrs)
{
  switch($name){
  case "NOTE":
    echo "-- Note --<br>";
    break;
  case "TO":
    echo "To: ";
    break;
  case "FROM":
    echo "From: ";
    break;
  case "HEADING":
    echo "Heading: ";
    break;
  case "BODY":
    echo "Message: ";
    break;
  default:
    break;
  }
}

function stop($xml,$name)
{
  echo "<br>";
}

function char($xml,$data)
{
  echo "{$data}";
}

xml_set_element_handler($xml,"start","stop");

xml_set_character_data_handler($xml,"char");
var_dump($fp = fopen("persion.xml","r"));
echo "<br>";

while($data = fread($fp,4096)){
  xml_parse($xml,$data,feof($fp)) or die(
    spritf("XML Error: %s at line %d: ",
    xml_error_string(xml_get_error_code($xml)),
    xml_get_current_line_number($xml)
  )
);
}

xml_parser_free($xml);

?>

