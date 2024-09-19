#include <iostream>
#include <ctime>
#include <cstdlib>
using namespace std;
void losowanie(int tablica[])
{
	for(int i=0;i<10;i++)
	{
		tablica[i]=rand()%10+1;
	}
}
int zamiana(int tablica[], int ile_wstawionych)
{
	int flaga=0;
	for(int j=0;j<10-ile_wstawionych-1;j++)
	{
		if(tablica[j]>tablica[j+1])
		{
			flaga=1;
			swap(tablica[j], tablica[j+1]);
		}
	}
	return flaga;
}
int sortowanie(int tablica[], int flaga)
{
	if(flaga==1)
	{
		return 0;
	}
	else {
		for(int i=0;i<10;i++)
		{
			zamiana(tablica, i);
		}
	}
}

void drukowanie(int tablica[])
{
	for(int i=0;i<10;i++)
	{
		cout<<tablica[i]<<" ";
	}
}
main()
{
	srand(time(NULL));
	int tablica[10];
	losowanie(tablica);
	drukowanie(tablica);
	cout<<"\n";
	sortowanie(tablica, 0);
	drukowanie(tablica);
}