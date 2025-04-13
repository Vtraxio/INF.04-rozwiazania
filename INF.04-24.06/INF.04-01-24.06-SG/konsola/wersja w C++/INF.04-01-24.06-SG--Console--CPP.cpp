#include <iostream>
#include <string>
#include <vector>

using namespace std;

/**************************************************************
  Nazwa:				Roll
  Opis:					Symuluje wybrana iloœæ rzutów kostk¹ i zwraca wszystkie wyniki.
  Parametry:			count - Ile zrobiæ rzutów kostk¹.
  Zwracany typ i opis:	lista liczb rzeczywistych - Wyniki wszystkich rzutów.
  Autor:				01234567890
**************************************************************/
vector<int> Roll(const int count) {
	vector<int> rolls;

	for (int i = 0; i < count; i++) {
		int roll = rand() % 6 + 1;
		rolls.push_back(roll);
		cout << "Kostka " << i << ": " << roll << "\n";
	}

	return rolls;
}

int CountPoints(vector<int> rolls) {
	int sum = 0;

	for (int roll : rolls) {
		if (count(rolls.begin(), rolls.end(), roll) >= 2) {
			sum += roll;
		}
	}

	return sum;
}

int main() {
	srand(time(nullptr));

	int rollCount = 0;
	do {
		cout << "Ile kostek chcesz rzucic? (3-10)\n";

		int num;
		cin >> num;

		if (num >= 3 && num <= 10) {
			rollCount = num;
		}
	} while (rollCount == 0);

	while (true) {
		auto rolls = Roll(rollCount);
		int points = CountPoints(rolls);
		cout << "Liczba uzyskanych punktow: " << points << "\n";

		cout << "Jeszcze raz? (t\\n)\n";
		char ans;
		cin >> ans;

		if (ans == 'n') {
			break;
		}
	}
}
