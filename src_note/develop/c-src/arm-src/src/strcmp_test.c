#include <stdio.h>
#include <string.h>

int main()
{
	printf("%d\n",strcmp("mkszy","mzdsx")); //-1 mzdsx 0=mzdsx 1=mkszy
	printf("%d\n",strcmp("mkszy","dxpll"));//1 1=mkszy 2=dxpll
	printf("%d\n",strcmp("dxpll","rlsz"));//-1 2=rlsz 3=dxpll
	printf("%d\n",strcmp("dxpll","yw"));//-1 3=yw 4=dxpll
	//1. mzdsx,mkszy,rlsz,yw,dxpll
	//mzdsx > mkszy?mzdsx:mkszy 0=mzdsx,1=mkszy
	//mkszy > rlsz?mkszy:rlsz 1=rlsz 2=mkszy
	//mkszy > yw?yw:mkszy 2=yw 3=mkszy
	//mkszy > dxpll?mkszy:dxpll 3=mkszy 4=dxpll
	//2. rsulst mzdsx,rlsz,yw,mkszy,dxpll
	//0=rlsz 1=mzdsx
	//1=yw 2=mzdsx
	//2=mzdsx 3=mkszy
	//3=mkszy 4=dxpll
	//3. rlsz,yw,mzdsx,mkszy,dxpll
	//0=yw,1=rlsz,2=mzdsx,3=mkszy,4=dxpll
	return 0;
}
