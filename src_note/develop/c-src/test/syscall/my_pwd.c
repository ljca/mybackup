#include <stdio.h>
#include <pwd.h>
#include <unistd.h>

int main()
{
	uid_t uid = getuid();
	gid_t gid = getgid();
	printf("uid = %d,gid = %d\n",uid,gid);
	struct passwd *pwd;
	pwd = getpwuid(uid);
	printf("passwd entry\n");
	printf("%s:%d:%d:%s:%s\n",pwd->pw_name,pwd->pw_uid,pwd->pw_gid,pwd->pw_dir,pwd->pw_shell);
}

