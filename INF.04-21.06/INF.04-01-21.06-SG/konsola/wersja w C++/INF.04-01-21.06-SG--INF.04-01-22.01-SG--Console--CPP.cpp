// ReSharper disable CppClangTidyClangDiagnosticInvalidUtf8

#include <iostream>
#include <array>

using namespace std;

class Sorter {
public:
	array<int, 10> Numbers;

	/**
	 * nazwa funkcji:       Sort
	 * parametry wejœciowe: brak - dzia³a na polu klasy
	 * parametry wyjœciowe: brak - posortowana tablica jest umieszczana w polu klasy
	 * autor:               01234567890
	 */
	void Sort() {
		for (int i = 0; i < Numbers.size(); i++) {
			const int maxIndex = FindMax(i);

			swap(Numbers[i], Numbers[maxIndex]);
		}
	}

private:
	/**
	* nazwa funkcji:       FindMax
	* parametry wejœciowe: startIndex - pocz¹tek zakresu listy do przeszukania
	* parametry wyjœciowe: int - indeks najwiêkszej wartoœci w podanym zakresie listy
	* autor:               01234567890
	*/
	int FindMax(const int startIndex) const {
		int biggestIndex = startIndex;
		for (int i = startIndex; i < Numbers.size(); i++) {
			if (Numbers[i] > Numbers[biggestIndex]) {
				biggestIndex = i;
			}
		}

		return biggestIndex;
	}
};

int main() {
	Sorter sorter{};

	cout << "Wprowadz 10 wartosci do posortowania:\n";

	for (int i = 0; i < 10; i++) {
		cout << "Wartosc " << i + 1 << ": ";
		int inputNumber;
		cin >> inputNumber;
		sorter.Numbers[i] = inputNumber;
	}

	sorter.Sort();

	cout << "Posortowane elementy\n";
	for (int i = 0; i < 10; i++) {
		cout << sorter.Numbers[i] << " ";
	}
}
