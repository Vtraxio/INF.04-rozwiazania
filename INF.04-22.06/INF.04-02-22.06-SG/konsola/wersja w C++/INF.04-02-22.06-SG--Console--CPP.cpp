#include <iostream>
#include <string>
#include <vector>

using namespace std;

class Osoba {
public:
	static int Instances;

private:
	int Id;
	string Name;

public:
	Osoba() {
		Id = 0;
		Name = "";
		Instances++;
	}

	Osoba(const int id, const string& name) {
		Id = id;
		Name = name;
		Instances++;
	}

	Osoba(const Osoba& other) {
		Id = other.Id;
		Name = other.Name;
		Instances++;
	}

	void print_name(const string& name) {
		if (Name.empty()) {
			cout << "Brak danych\n";
		} else {
			cout << "Czesc " << name << ", mam na imie " << Name << "\n";
		}
	}
};

int Osoba::Instances = 0;

int main() {
	cout << "Liczba zarejestrowanych osob to " << Osoba::Instances << "\n";

	vector<Osoba> osoby{};
	// Musimy to zrobic, aby zapobiec niepotrzebnym realokacjnom ktore ponownie by wywowaly konstruktor kopiowania
	osoby.reserve(3);

	osoby.emplace_back();

	cout << "Wprowadz id nowej osoby: ";
	int id;
	cin >> id;
	cout << "Wprowadz imie nowej osoby: ";
	string name;
	cin >> name;

	osoby.emplace_back(id, name);

	osoby.emplace_back(osoby.back());

	for (Osoba& osoba : osoby) {
		osoba.print_name("Jan");
	}

	cout << "Liczba zarejestrowanych osob to " << Osoba::Instances << "\n";
}
