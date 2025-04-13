var film = new Film();
Console.WriteLine($"Tytuł: {film.GetTitle()}, Wypożyczenia: {film.GetRentedNum()}");

film.SetTitle("Shrek 5");
Console.WriteLine($"Tytuł po ustawieniu: {film.GetTitle()}");

Console.WriteLine($"Wypożyczenia przed zwiększeniem: {film.GetRentedNum()}");
film.AddRental();
Console.WriteLine($"Wypożyczenia po zwiększeniu: {film.GetRentedNum()}");

/**************************************************************
  Nazwa klasy:	Film
  Pola:			Title - Tytuł filmu
				RentedNum - Ile razy został wypożyczony film
  Metody:		SetTitle, void - Ustawia tytuł filmu
				GetTitle, string - Zwraca tytuł filmu
				GetRentedNum, int - Zwraca ilość wypożyczeń filmu
				AddRental, void - Dodaje nowe wypożyczenie
  Informacje:	Klasa reprezentuje Film w wirtualnej wypożyczalni filmów.
  Autor:		01234567890
**************************************************************/
class Film {
	protected string Title;
	protected int    RentedNum;

	public Film() {
		Title     = string.Empty;
		RentedNum = 0;
	}

	public void SetTitle(string title) {
		Title = title;
	}

	public string GetTitle() {
		return Title;
	}

	public int GetRentedNum() {
		return RentedNum;
	}

	public void AddRental() {
		RentedNum++;
	}
}