# Tomarow Task
1. 链表排序

```c
struct node *
link_sort(struct node *head)
{
  struct node *new_head;
  struct node *tmp = head;
  struct node *min,*min_pre;
  min = head,min_pre = NULL;
  while(head){
    min = head;
    min_pre = NULL;
    while(tmp->next){
      if(tmp->next-index < tmp->index){
        min = tmp->next;
        min_pre = tmp;
      }
      tmp = tmp->next;
      if(min == head){
        head = head->next;
      }else{
        min->next = head;
      }
    }
  }
  return new_head;
}
```

2. TCP 网络聊天程序

```c
/* client.c */
int main(int argc,char **argv)
{
  if(argc != 2){
    fprintf(stderr,"Usage: %s <ip/host>\n",argv[0]);
    return;
  }
  int sfd;
  if((sfd = socket(AF_INET,SOCK_STREAM,0)) == -1){
    perror("create socket error");
    retrurn -1;
  }
  struct sockaddr_in client;
  bzero(&client,sizeof(client));
  client.sin_family = AF_INET;
  client.sin_port = htons(PORT);
  if(inet_pton(AF_INET,argv[1],&client.sin_addr) == -1){
    perror("convert ipaddress error");
    return;
  }
  if(connect(sfd,(SA *)&client,sizeof(client)) == -1){
    perror("connect server error");
    return;
  }
  int n;
  char buf[BUFSIZ] = {0};
}

/* server.c */
#define PORT 
#define SA (struct sockaddr)
int main()
{
  int sfd,connsfd;
  if((sfd = socket(AF_INET,SOCK_STREAM,0)) == -1){
    perror("create socket error");
    return;
  }
  struct sockaddr_in server,client;
  bzero(&server,sizeof(server));
  server.sin_port = htons(PORT);
  server.sin_family = AF_INET;
  server.sin_addr = htonl(INADDR_ANY);
  if(bind(sfd,(SA *)&server,sizeof(server)) == -1){
    perror("bind socket error");
  }

  if(listen(sfd,5) == -1){
    perror("listen socket error");
  }

  socklen len = 0;
  int n;
  char buf[BUFSIZ + 1] = {0};
  while((n = read(sfd,buf,strlen(buf))) > 0){
    len = sizeof(client);
    connsfd = accept(sfd,(SA *)&client,&len);
    write(sfd,buf,strlen(buf));
    sprintf(buf,"connect from %s，port is %d\n",inet_ntop(AF_INET,&client.sin_addr,buf,sizeof(buf)),ntohs(client.sin_port));
    fputs(buf,stdout);
    close(connsfd);
  }
  if(n < 0){
    perror("");
  }
}

/* Makefile */
all:client server

.PHONY:run clean
run:
su -c './server &' \
     ./client 
```

3. TCP 网络文件传输

```c
```

4. 实现 C 语言操作数据库的增删改查

```c
/* 如果数据库是 MySQL，连接 关闭 */
/* 获取 MySQL 连接 */
  MYSQL *
mysql mysql_conn()
{
  MYSQL *mysql;
  const char *dbname = "";
  if(!(mysql = mysql_init(NULL))){
    fprintf(stderr,"init mysql error.errno: %d,errmsg: %s\n",mysql_errno(mysql),mysql_error(mysql));
    return NULL;
  }
  if(!mysql_real_connect(mysql,NULL,user,passwd,dbname,0,NULL,0)){
    fprintf(stderr,"connect mysql error.errno: %d,errmsg: %s\n",mysql_errno(mysql),mysql_error(mysql));
    return;
  }
  return mysql;
}
/* 关闭 MySQL 连接 */
void mysql_clo(MYSQL *mysql)
{
  if(mysql_close(mysql) != 0){
    fprintf(stderr,"errno: %d,errmsg: %s\n",mysql_errno(mysql),mysql_error(mysql));
  }
}
```

```c
/* */
int moditify_res(char *sql)
{
  MYSQL *mysql;
  mysql = mysql_conn();
  int res;
  if((res = mysql_exec(sql)) < 0){
    fprintf(stderr,"modifify table errer.errno: %d,errmsg: %s\n",mysql_errno(mysql),mysql_error(mysql));
  }
  mysql_clo(mysql);
  return res;
}
/* 增 */
int mysql_add_res(int id)
{
  char sql[128] = {0};
  sprintf(sql,"insert into table(id) values('%d')",id);
  return moditify_res(sql,num);
  //fprintf(stdout,"insert resolutions executeble sucess!\n");
}
/* 删 */
int del_res(int id)
{
  char sql[128] = {0};
  sprintf(sql,"insert into table(id) values('%d')",id);
  retrurn moditify_res(sql);
  //fprintf(stdout,"delete table resolution sucess!\n");
}
/* 改 */
int mod_res(int id,int new_id)
{
  char sql[128] = {0};
  sprintf(sql,"update table_name set id = '%d' where id = '%d'",new_id,id);
  return moditify_res(sql);
  //fprintf(stdout,"update table sucess!\n");
}
/* 查：未实现 */
void select_res(int id)
{
  char sql[128] = "select * from table_name";
  if(id < 0){
    fprintf(stderr,"%d 不是一个有效的数字(id >=0).\n",id);
  }
  sprintf(sql," where id = %d",id);
  MYSQL *mysql = mysql_conn();
  mysql_clo(mysql);
}
```

