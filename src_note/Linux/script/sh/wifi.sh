#!/bin/bash -
#===============================================================================
#
#          FILE: wifi.sh
# 
#         USAGE: source wifi.sh or . wifi.sh
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#         NOTES: ---
#        AUTHOR: ljca
#  ORGANIZATION: 
#       CREATED: 10/19/2016 00:42
#      REVISION:  ---
#===============================================================================

[ -z "${dhcp}" ] && dhcp=

function wifi_init()
{
  echo "Init network devices....."
	 case $OS in
    Arch*)
      dhcp=dhcpcd;;
    Fedora*)
      dhcp=dhclient;;
      *)
      dhcp=dhcpcd;;
  esac
}


function wifi_down()
{
	for i in `ps aux|grep -v grep|grep wlp3s0|awk '{print $2}'`;do 
		${SUDO} kill $i &>/dev/null;unset i
	done

	${SUDO} rm -f /var/run/wpa_supplicant/wlp3s0 >& /dev/null
	${SUDO}  kill `cat /run/dhcpcd-wlp3s0.pid 2>/dev/null` &>/dev/null
  ${SUDO} ip link set wlp3s0 down
}

function wifi_up()
{
  if ping -c 2 www.baidu.com &>/dev/null && ps aux|grep -v grep|grep -i 'wlp3s0' &> /dev/null;then echo "Network is ok...."
  elif ps aux|grep -v grep|grep -i "dhcp" &>/dev/null;then echo "The wpa_supplicant and dhcpcd is ok,But network is not working,Please select a good location and waiting for......"
  else 
    wifi_init && wifi_down
    ${SUDO} ip link set wlp3s0 up
    ${SUDO} wpa_supplicant -iwlp3s0 -c /etc/wpa_supplicant/wpa_supplicant.conf -B &&${SUDO} $dhcp wlp3s0
  fi

}

function wifi_set()
{
  case $1 in
    up)
      wifi_up ;;
    down)
      wifi_down ;;
    --help|-h)
      echo -e "Usage: $FUNCNAME up|down" ;;
    *)
      echo "argument is faild or not set,executeble deafult commands."
      net_ck ;;
  esac
}

function net_ck()
{
  echo "Checking the networks..."
  ping -c 3 www.baidu.com &> /dev/null && echo "Network is ok.." || echo "Network is not working..."
}

export -f net_ck wifi_set
unset dhcp
#unset -f wifi_init
#${SUDO} wpa_supplicant -iwlp3s0 -c <(wpa_passphrase "BUNFLY_01" "bunfly.com") -B&&SUDO dhcpcd wlp3s0
#
