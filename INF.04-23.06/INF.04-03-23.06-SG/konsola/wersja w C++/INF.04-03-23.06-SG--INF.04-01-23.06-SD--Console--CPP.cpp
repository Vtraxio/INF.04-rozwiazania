#include <iostream>
#include <string>

using namespace std;

/**************************************************************
  Nazwa klasy:	Film
  Pola:			Title - Tytul filmu
				RentedNum - Ile razy zostal wypozyczony film
  Metody:		SetTitle, void - Ustawia tytul filmu
				GetTitle, string - Zwraca tytul filmu
				GetRentedNum, int - Zwraca ilosc wypozyczen filmu
				AddRental, void - Dodaje nowe wypozyczenie
  Informacje:	Klasa reprezentuje Film w wirtualnej wypozyczalni filmow.
  Autor:		01234567890
**************************************************************/
class Film {
protected:
	string Title;
	int RentedNum;

public:
	Film() {
		Title = "";
		RentedNum = 0;
	}

	void SetTitle(const string& title) {
		Title = title;
	}

	string GetTitle() {
		return Title;
	}

	int GetRentedNum() {
		return RentedNum;
	}

	void AddRental() {
		RentedNum++;
	}
};

int main() {
	Film film{};
	cout << "Tytul: " << film.GetTitle() << ", Wypozyczenia: " << film.GetRentedNum() << "\n";

	film.SetTitle("Shrek 5");
	cout << "Tytul po ustawieniu: " << film.GetTitle() << "\n";

	cout << "Wypozyczenia przed zwiekszeniem: " << film.GetRentedNum() << "\n";
	film.AddRental();
	cout << "Wypozyczenia po zwiekszeniu: " << film.GetRentedNum() << "\n";
}
