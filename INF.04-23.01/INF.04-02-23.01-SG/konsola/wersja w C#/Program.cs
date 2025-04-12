var note1 = new Notatka("Bee Movie Script", "According to all known laws of aviation, there is no way a bee should be able to fly.");
var note2 = new Notatka("Fajna notatka",    "Treść notatki pobudzająca wrażenie");

note1.Display();
note1.Diagnose();

note2.Display();
note2.Diagnose();

/**************************************************************
  Klasa:	notatka
  Opis:		Reprezentuje notatkę z tytułem oraz opisem.
  Pola:		_instances - statyczna zmienna zawierająca liczbę utworzonych notatek,
				wspólna dla wszystkich instancji klasy.
			_id - unikatowy identyfikator dla notatki.
			Title - Tytuł notatki.
			Content - Treść notatki.
  Autor:	01234567890
**************************************************************/
class Notatka {
	private static int _instances;

	private int _id;

	protected string Title;
	protected string Content;

	public Notatka(string title, string content) {
		_instances++;
		_id = _instances;

		Title   = title;
		Content = content;
	}

	public void Display() {
		Console.WriteLine($"Tytuł: {Title} - Treść: {Content}");
	}

	public void Diagnose() {
		Console.WriteLine($"{_instances};{_id};{Title};{Content}");
	}
}