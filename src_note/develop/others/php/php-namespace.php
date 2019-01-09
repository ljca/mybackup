<?php
#
declare(encoding='utf-8');
namespace myphp{
const CONNECT_OK = 1;
class Connection{
  function connection(){}
}
function start(){}
}

namespace{
session_start();
myphp\Connection::connection();
echo myphp::CONNECT_OK;
myphp::start();
}

#echo constant('myphp\CONNECT_OK');

?>
