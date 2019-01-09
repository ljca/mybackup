#include <unistd.h>

int main()
{
  execl("/bin/ps","ps","aux",0);
}
