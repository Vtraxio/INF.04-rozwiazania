#include <iostream>
#include <vector>

using namespace std;

void Fill(vector<bool>& array) {
	for (int i = 0; i < array.size(); i++) {
		array[i] = true;
	}
}

/**************************************************************
  Nazwa funkcji:		Fill
  Parametry wejsciowe:	array - Tablica z typami bool, ktora funkcja ma wypelnic,
							wartoscia true.
  Wartosc zwracana:		Brak
  Informacje:			Wypelnia 100 elementow w tablicy 'array' wartoscia true.
  Autor:				01234567890
**************************************************************/
int main() {
	vector<bool> a(100);

	Fill(a);

	for (int i = 2; i <= 10; i++) {
		if (a[i]) {
			for (int j = 2 * i; j < 100; j += i) {
				a[j] = false;
			}
		}
	}

	cout << "Liczby pierwsze od 2 do 100: ";
	for (int i = 2; i < a.size(); i++) {
		if (a[i])
			cout << i << " ";
	}
}
