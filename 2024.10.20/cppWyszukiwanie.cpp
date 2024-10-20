//sortowanie i wyszukiwanie tablice
#include <bits/stdc++.h>
using namespace std;
class Egz
{
private:
    // Funkcje pomocnicze, które nie muszą być dostępne na zewnątrz
    void losowanie(int tab[], int n)
    {
        for (int i = 0; i < n; i++)
        {
            tab[i] = rand() % 10 + 1;
        }
    }

    void sortBomb(int tab[], int n)
    {
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (tab[j] > tab[j + 1])
                {
                    swap(tab[j], tab[j + 1]);
                }
            }
        }
    }

public:
    void prepare(int tab[], int n)
    {
        losowanie(tab, n);  // Losowanie elementów
        sortBomb(tab, n);   // Sortowanie tablicy
    }

    int binarne(int l, int p, int tab[], int szukana)
    {
        while (l <= p)
        {
            int sr = (l + p) / 2;
            if (tab[sr] == szukana)
            {
                return sr;
            }
            else if (szukana < tab[sr])
            {
                p = sr - 1;
            }
            else
            {
                l = sr + 1;
            }
        }
        return -1;
    }
};

main()
{
	Egz egzamin;
	int n, szuk;
	srand(time(NULL));
	cout<<"podaj liczbe elementow tablicy, ktore chcesz wylosowac"<<endl;
	cin>>n;
		int* tab=new int[n];

	cout<<"podaj poszukiwana liczbe"<<endl;
	cin>>szuk;
	egzamin.prepare(tab, n);
	int binRes=egzamin.binarne(0, n-1, tab, szuk);	
	if(binRes==-1)
	{
		cout<<"nie znaleziono liczby"<<endl;
	}
	cout<<"liczba "<<szuk<<" znajduje się na pozycji: "<<binRes<<endl;
	
}