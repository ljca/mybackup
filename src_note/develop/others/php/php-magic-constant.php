<?php
#
namespace myphp;

function test_func()
{
  echo "current dir: ". __DIR__ . "<br>";
  #echo "in ". __FILE__ . ",at ". __LINE__ . "line numbers.<br>" ;
  #echo "function name: ". __FUNCTION__. "<br>";
  printf('error: in file: %s, at the %d line numbers in %s().',__FILE__,__LINE__,__METHOD__);
  echo "<br>";
}

test_func();

class Test{
  function _print()
  {
    #__CLASS__,
    #__NAMESPACE__
    printf('error: in file: %s, at the %d line numbers in %s().',__FILE__,__LINE__,__METHOD__);
    echo "<br>";
  }
}

$test = new Test();
$test->_print();

unset($test);
?>

