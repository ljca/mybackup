#include <stdio.h>
#include <netinet/in.h>
#include <sys/socket.h>
#include <string.h>
#include <linux/if_ether.h>
#include <unistd.h>
#include <arpa/inet.h>
typedef int int32;
typedef unsigned int u_int32;
typedef unsigned char u_char;
typedef unsigned short u_short;
typedef struct macaddr{
	char des_addr[6];
	char src_addr[6];
	short d_type;
}__attribute__ ((packed)) MAC_ADDR;


typedef struct i_dp{
	u_short i_type;
	u_short p_type;
	u_char hw_len;
	u_char p_len;
	u_short p_opt;
	char des_addr[6];
	char src_ip[4];
	char src_addr[6];
	char des_ip[4];
}__attribute__ ((packed)) IDP;

int main(int argc,char *argv[])
{
	if(2 != argc){
		printf("no command line arg\n");return 0;
	} 
	int sfd;
	if(-1 ==(sfd = socket(PF_PACKET,SOCK_RAW,htons(ETH_P_ALL)))){
		perror("socket error");
		return -1;
	}
	char buf[1024];
	while(1){
		memset(&buf,0,sizeof(buf));
		int ret = 0;
		if(-1 == (ret= recvfrom(sfd,buf,sizeof(buf),0,NULL,NULL))){
			perror("");
			break;
		}
		MAC_ADDR *mac_hdr; 
		mac_hdr = buf;
		char *tmp1 = mac_hdr->src_addr;
		char *tmp2 = mac_hdr->des_addr;
		printf("%.2X:%.2X:%.2X:%.2X:%.2X:%.2X ====> " "%.2X:%.2X:%.2X:%.2X:%.2X:%.2X",tmp1[0]&0xFF,tmp1[1]&0xFF,tmp1[2]&0xFF,tmp1[3]&0xFF,tmp1[4]&0xFF,tmp1[5]&0xFF,tmp2[0]&0xFF,tmp2[1]&0xFF,tmp2[2]&0xFF,tmp2[3]&0xFF,tmp2[4]&0xFF,tmp2[5]&0xFF);
		printf("\n");
		IDP *idp;
		idp = buf+sizeof(MAC_ADDR);
		tmp1 = idp->src_ip;
		tmp2 = idp->des_ip;
		printf("%.2d:%.2d:%.2d:%.2d ======> " "%.2d:%.2d:%.2d:%.2d\n",tmp1[0]&0xFF,tmp1[1]&0xFF,tmp1[2]&0xFF,tmp1[3]&0xFF,tmp2[0]&0xFF,tmp2[1]&0xFF,tmp2[2]&0xFF,tmp2[3]&0xFF);
	}
	close(sfd);
	return 0;
}
