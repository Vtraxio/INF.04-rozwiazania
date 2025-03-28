var sorter = new Sorter();

Console.WriteLine("Wprowadź 10 wartości do posortowania:");

for (var i = 0; i < 10; i++) {
	Console.Write($"Wartość {i + 1}: ");
	var inputValue = int.Parse(Console.ReadLine() ?? "0");
	sorter.Numbers[i] = inputValue;
}

sorter.Sort();

Console.WriteLine("Posortowane elementy");
Console.WriteLine(string.Join(' ', sorter.Numbers));

class Sorter {
	public int[] Numbers = new int[10];

	/**
	 * nazwa funkcji:       Sort
	 * parametry wejściowe: brak - działa na polu klasy
	 * parametry wyjściowe: brak - posortowana tablica jest umieszczana w polu klasy
	 * autor:               01234567890
	 */
	public void Sort() {
		for (var i = 0; i < Numbers.Length; i++) {
			var maxIndex = FindMax(i);

			(Numbers[maxIndex], Numbers[i]) = (Numbers[i], Numbers[maxIndex]);
		}
	}

	/**
	* nazwa funkcji:       FindMax
	* parametry wejściowe: startIndex - początek zakresu listy do przeszukania
	* parametry wyjściowe: int - indeks największej wartości w podanym zakresie listy
	* autor:               01234567890
	*/
	private int FindMax(int startIndex) {
		var biggestIndex = startIndex;
		for (var i = startIndex; i < Numbers.Length; i++) {
			if (Numbers[i] > Numbers[biggestIndex]) {
				biggestIndex = i;
			}
		}

		return biggestIndex;
	}
}