Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.Instances}");
List<Osoba> osoby = [];

osoby.Add(new Osoba());

Console.Write("Wprowadź id nowej osoby: ");
var id = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Wprowadź imię nowej osoby: ");
var name = Console.ReadLine();

osoby.Add(new Osoba(id, name));

osoby.Add(new Osoba(osoby[1]));

foreach (var osoba in osoby) {
	osoba.print_name("Jan");
}

Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.Instances}");

class Osoba {
	public static int Instances;

	private int    _id;
	private string _name;

	public Osoba() {
		_id   = 0;
		_name = string.Empty;
		Instances++;
	}

	public Osoba(int id, string name) {
		_id   = id;
		_name = name;
		Instances++;
	}

	public Osoba(Osoba other) {
		_id   = other._id;
		_name = other._name;
		Instances++;
	}

	public void print_name(string name) {
		if (_name == string.Empty) {
			Console.WriteLine("Brak danych");
		} else {
			Console.WriteLine($"Cześć {name}, mam na imię {_name}");
		}
	}
}