var list = new int[100];

var random = new Random();
for (var i = 0; i < list.Length; i++) {
	list[i] = random.Next(0, 1000);
}

Sort(list);

Console.WriteLine($"Posortowana tablica: {string.Join(", ", list)}");


void Sort(int[] listToSort) {
	for (var i = 0; i < listToSort.Length - 1; i++) {
		for (var j = 0; j < listToSort.Length - i - 1; j++) {
			if (listToSort[j] > listToSort[j + 1])
				(listToSort[j], listToSort[j + 1]) = (listToSort[j + 1], listToSort[j]);
		}
	}
}