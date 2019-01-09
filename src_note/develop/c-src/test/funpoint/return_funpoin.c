
int (*p(int))(int);

int main()
{
}

int (*p(int num))(int num2)
{
	int (*p)(int);
	return p;
}

/*  vim:set st=2 sts=2 ts=2 ai ci si et:  */
