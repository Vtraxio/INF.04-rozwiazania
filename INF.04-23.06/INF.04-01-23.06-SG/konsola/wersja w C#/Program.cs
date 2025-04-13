var a = new bool[100];

Fill(a);

for (var i = 2; i <= 10; i++) {
	if (a[i]) {
		for (var j = 2 * i; j < 100; j += i) {
			a[j] = false;
		}
	}
}

Console.Write("Liczby pierwsze od 2 do 100: ");
for (var i = 2; i < 100; i++) {
	if (a[i]) {
		Console.Write($"{i} ");
	}
}

/**************************************************************
  Nazwa funkcji:		Fill
  Parametry wejściowe:	array - Tablica z typami bool, którą funkcja ma wypełnić,
							wartością true.
  Wartość zwracana:		Brak
  Informacje:			Wypełnia 100 elementów w tablicy 'array' wartością true.
  Autor:				01234567890
**************************************************************/
void Fill(bool[] array) {
	for (var i = 0; i < array.Length; i++) {
		array[i] = true;
	}
}