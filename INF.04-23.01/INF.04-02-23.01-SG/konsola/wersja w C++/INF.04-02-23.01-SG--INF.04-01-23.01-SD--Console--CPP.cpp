#include <iostream>
#include <string>

using namespace std;

/**************************************************************
  Klasa:	notatka
  Opis:		Reprezentuje notatke z tytulem oraz opisem.
  Pola:		_instances - statyczna zmienna zawierajaca liczbe utworzonych notatek,
				wspolna dla wszystkich instancji klasy.
			_id - unikatowy identyfikator dla notatki.
			Title - Tytul notatki.
			Content - Tresc notatki.
  Autor:	01234567890
**************************************************************/
class Notatka {
private:
	static int Instances;
	int Id;

protected:
	string Title;
	string Content;

public:
	Notatka(const string& title, const string& content) {
		Instances++;
		Id = Instances;

		Title = title;
		Content = content;
	}

	void Display() {
		cout << "Tytul: " << Title << " - Tresc: " << Content << "\n";
	}

	void Diagnose() {
		cout << Instances << ";" << Id << ";" << Title << ";" << Content << "\n";
	}
};

int Notatka::Instances = 0;

int main() {
	Notatka note1{ "Bee Movie Script", "According to all known laws of aviation, there is no way a bee should be able to fly." };
	Notatka note2{ "Fajna notatka", "Tresc notatki pobudzajaca wrazenie" };

	note1.Display();
	note1.Diagnose();

	note2.Display();
	note2.Diagnose();
}
