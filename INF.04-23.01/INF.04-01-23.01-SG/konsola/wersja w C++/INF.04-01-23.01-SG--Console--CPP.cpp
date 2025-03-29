#include <iostream>

using namespace std;

/**************************************************************
 nazwa funkcji:			nwd
 opis funkcji:			znajduje NWD parametrow a i b przy uzyciu
						algorytmu Euklidesa.
 parametry:				a - pierwsza liczba
						b - druga liczba
 zwracany typ i opis:	uint - liczba calkowita, ktora jest
						NWD liczb a i b
 autor:					01234567890
 *************************************************************/
unsigned int nwd(unsigned int a, unsigned int b) {
	while (a != b) {
		if (a > b)
			a -= b;
		else
			b -= a;
	}

	return a;
}

int main() {
	cout << "Wprowadz liczbe a: ";
	unsigned int a;
	cin >> a;
	cout << "Wprowadz liczbe b: ";
	unsigned int b;
	cin >> b;

	unsigned int result = nwd(a, b);
	cout << "NWD liczb " << a << " i " << b << " to " << result << "\n";
}
