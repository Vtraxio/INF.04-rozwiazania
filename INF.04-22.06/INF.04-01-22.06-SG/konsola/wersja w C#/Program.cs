using System.Diagnostics;

const int length = 50;

var list = new int[length + 1];

FillList(list);

Console.Write("Wpisz liczbę do wyszukania: ");
var number = int.Parse(Console.ReadLine() ?? "0");
list[length] = number;

Console.WriteLine($"Wygenerowana lista: {string.Join(", ", list[..length])}");

var foundIndex = FindIndex(list, number);
if (foundIndex is null) {
	Console.WriteLine("Nie znaleziono!");
} else {
	Console.WriteLine($"Znaleziono na pozycji {foundIndex}");
}

void FillList(int[] listToFill) {
	for (var i = 0; i < listToFill.Length; i++) {
		listToFill[i] = new Random().Next(1, 101);
	}
}

/**************************************************************
 nazwa funkcji: FindIndex
 argumenty:		searchList - lista w której funkcja ma znaleźć daną liczbę
				numberToFind - liczba którą funkcja ma znaleźć w liście
 typ zwracany:	int lub null, jeśli podany element został znaleziony
				w liście, zwracamy jego index, jeśli nie zwracamy null
 informacja:	Ta funkcja implementuje algorytm wyszukiwania elementu
				z wartownikiem.
 autor:			01234567890
 *************************************************************/
int? FindIndex(int[] searchList, int numberToFind) {
	for (var i = 0; i < searchList.Length; i++) {
		if (searchList[i] != numberToFind) continue;
		if (i == length) {
			return null;
		}

		return i;
	}

	Debug.Fail("Nie powinieneś tu być :O");
	return null;
}