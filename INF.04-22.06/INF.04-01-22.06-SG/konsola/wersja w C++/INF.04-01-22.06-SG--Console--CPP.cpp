#include <iostream>
#include <array>
#include <optional>

using namespace std;

constexpr int LENGTH = 50;
using Arr = array<int, LENGTH + 1>;

void FillList(Arr& listToFill) {
	for (int i = 0; i < LENGTH; i++) {
		listToFill[i] = rand() % 100 + 1;
	}
}

/**************************************************************
 nazwa funkcji: FindIndex
 argumenty:		searchList - lista w ktorej funkcja ma znalezc dana liczbe
				numberToFind - liczba ktora funkcja ma znalezc w liscie
 typ zwracany:	optional z typem int, jesli podany element zostal znaleziony
                w liscie, optional posiada wartosc indexu tego elementu,
				jesli nie zostal znaleziony, optional nie posiada wartosci
 informacja:	Ta funkcja implementuje algorytm wyszukiwania elementu
				z wartownikiem.
 autor:			01234567890
 *************************************************************/
optional<int> FindIndex(const Arr& searchList, int numberToFind) {
	for (int i = 0; i < searchList.size(); i++) {
		if (searchList[i] != numberToFind)
			continue;
		if (i == LENGTH) {
			return {};
		}

		return i;
	}

	throw exception("Nie powinienes tu byc :O");
}

int main() {
	srand(time({}));

	Arr list;
	FillList(list);

	cout << "Wpisz liczbe do wyszukania: ";
	int number;
	cin >> number;
	list[LENGTH] = number;

	for (int i = 0; i < LENGTH; i++) {
		cout << list[i];

		if (i != LENGTH - 1)
			cout << ", ";
	}
	cout << "\n";

	auto foundIndex = FindIndex(list, number);
	if (foundIndex.has_value()) {
		cout << "Znaleziono na pozycji " << foundIndex.value();
	} else {
		cout << "Nie znaleziono!";
	}
}
