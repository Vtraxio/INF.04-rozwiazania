#include <iostream>
#include <vector>

using namespace std;

void Sort(vector<int>& listToSort) {
	for (int i = 0; i < listToSort.size() - 1; i++) {
		for (int j = 0; j < listToSort.size() - i - 1; j++) {
			if (listToSort[j] > listToSort[j + 1])
				swap(listToSort[j], listToSort[j + 1]);
		}
	}
}

int main() {
	vector<int> list;
	list.reserve(100);

	srand(time(nullptr));
	for (int i = 0; i < 100; i++) {
		list.push_back(rand() % 1000);
	}

	Sort(list);

	cout << "Posortowana lista: ";
	for (int i = 0; i < list.size(); i++) {
		cout << list[i];

		if (i != list.size() - 1) {
			cout << ", ";
		}
	}
}
