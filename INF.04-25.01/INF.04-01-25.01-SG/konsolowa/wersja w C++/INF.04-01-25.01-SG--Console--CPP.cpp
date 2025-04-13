#include <iostream>

using namespace std;

class ArrayOperations {
private:
	int* Array;
	int ArrayElements;

public:
	ArrayOperations(const int arrayElements) {
		ArrayElements = arrayElements;

		Array = new int[ArrayElements];

		for (int i = 0; i < ArrayElements; i++) {
			Array[i] = rand() % 999 + 1;
		}
	}

	void DisplayElements() {
		for (int i = 0; i < ArrayElements; i++) {
			cout << i << ": " << Array[i] << "\n";
		}
	}

	int FindElement(int element) {
		for (int i = 0; i < ArrayElements; i++) {
			if (Array[i] == element)
				return i;
		}

		return -1;
	}

	/*************************************************************
	  Nazwa metody:			PrintOddAndReturn
	  Opis metody:			Wypisuje Wszystkie liczby nieparzyste w klasie oraz zwraca ich ilosc
	  Parametry:			brak
	  Zwracany typ i opis:	int, liczba nieparzystych elementow w liscie
	  Autor:				01234567890
	*************************************************************/
	int PrintOddAndReturn() {
		int count = 0;

		cout << "Liczby nieparzyste:\n";

		for (int i = 0; i < ArrayElements; i++) {
			if (Array[i] % 2 == 1) {
				count++;
				cout << Array[i] << "\n";
			}
		}

		return count;
	}

	int Average() {
		int sum = 0;

		for (int i = 0; i < ArrayElements; i++) {
			sum += Array[i];
		}

		return sum / ArrayElements;
	}
};

int main() {
	srand(time(nullptr));

	ArrayOperations arrayOps{21};

	arrayOps.DisplayElements();

	int idx = arrayOps.FindElement(69);
	if (idx != -1)
		cout << "Wartosc 69 jest w indexie " << idx << "\n";

	cout << "Razem nieparzystych: " << arrayOps.PrintOddAndReturn() << "\n";
	cout << "Srednia wszystkich elementow: " << arrayOps.Average() << "\n";
}
