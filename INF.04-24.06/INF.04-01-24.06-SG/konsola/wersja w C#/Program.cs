var rollCount = 0;
do {
	Console.WriteLine("Ile kostek chcesz rzucić? (3-10)");
	var str = Console.ReadLine() ?? "0";

	if (!int.TryParse(str, out var num)) {
		continue;
	}

	if (num is >= 3 and <= 10) {
		rollCount = num;
	}
} while (rollCount == 0);

while (true) {
	var rolls = Roll(rollCount);
	var points = CountPoints(rolls);
	Console.WriteLine($"Liczba uzyskanych punktów: {points}");

	Console.WriteLine("Jeszcze raz? (t/n)");
	var ans = Console.ReadLine() ?? "n";

	if (ans == "n") {
		break;
	}
}

/**************************************************************
  Nazwa:				Roll
  Opis:					Symuluje wybrana ilość rzutów kostką i zwraca wszystkie wyniki.
  Parametry:			count - Ile zrobić rzutów kostką.
  Zwracany typ i opis:	lista liczb rzeczywistych - Wyniki wszystkich rzutów.
  Autor:				01234567890
**************************************************************/
List<int> Roll(int count) {
	var       random = new Random();
	List<int> rolls  = [];

	for (var i = 0; i < count; i++) {
		var roll = random.Next(1, 7);
		rolls.Add(roll);
		Console.WriteLine($"Kostka {i}: {roll}");
	}

	return rolls;
}

int CountPoints(List<int> rolls) {
	return rolls.GroupBy(x => x).Where(x => x.Count() >= 2).SelectMany(x => x).Sum();
}