set pause on
set pause 'Press Enter Key Continue.........'
set linesize 256
set pagesize 100
set time on
set timing on
define_editor=gvim
set serveroutput on size 2000
column plan_plus_exp format a35
/*
set termout off
define user_name=""
define instanceName=""
column user_name new_value user_name
column instanceName new_value istanceName
select lower(user) user_name,upper(instance_name) instanceName from v$instance;
set sqlprompt '&user_name:&instanceName> '
set termout on
*/
--set sqlprompt "_user'@'_connect_identifier> "
set sqlprompt '&_user:&_connect_identifier> '
