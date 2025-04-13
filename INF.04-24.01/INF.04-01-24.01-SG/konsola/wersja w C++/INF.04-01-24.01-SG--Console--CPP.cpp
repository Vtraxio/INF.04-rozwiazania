#include <iostream>
#include <string>

using namespace std;

const int weights[] = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

char CheckGender(const string& pesel) {
	return (pesel[9] - '0') % 2 == 0 ? 'K' : 'M';
}

bool CheckValidity(const string& pesel) {
	int S = 0;

	for (int i = 0; i < 10; i++) {
		S += (pesel[i] - '0') * weights[i];
	}

	int M = S % 10;

	int R = M == 0 ? 0 : 10 - M;

	return R == pesel[10] - '0';
}

int main() {
	cout << "Wpisz pesel: ";
	string pesel;
	getline(cin, pesel);

	if (pesel.empty())
		pesel = "55030101193";

	cout << (CheckGender(pesel) == 'K' ? "Kobieta" : "Mezczyzna") << "\n";
	cout << (CheckValidity(pesel) ? "Pesel poprawny" : "Pesel niepoprawny") << "\n";
}
