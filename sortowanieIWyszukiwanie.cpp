#include <bits/stdc++.h>
using namespace std;
class wysz {
	int tablica1[100];
	int* tablica2[];
	void losuj();
	void drukuj();
	void sort_bable();
	void sort_wybor();
	void sort_wstaw();
	void sort_scal();
	void sort_quick();
	int wysz_wart();
	int wysz_liniowe();
	int wysz_bin();
};
wysz::sort_wstaw()
{
	int x;
	int i=0;
	int j=0;
	for( j=n-1;j>0;j--)
	{
		x=d[j];
		i=j+1;
		while(i<=n && x>d[i])
		{
			d[i-1] =d[i];
		}
		d[i-1]=x;
	}
}
main()
{
	
}