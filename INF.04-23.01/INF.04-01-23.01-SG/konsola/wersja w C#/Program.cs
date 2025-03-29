Console.Write("Wprowadź liczbę a: ");
var a = uint.Parse(Console.ReadLine() ?? "0");
Console.Write("Wprowadź liczbę b: ");
var b = uint.Parse(Console.ReadLine() ?? "0");

var result = nwd(a, b);
Console.WriteLine($"NWD liczb {a} i {b} to {result}");


/**************************************************************
 nazwa funkcji:			nwd
 opis funkcji:			znajduje NWD parametrów a i b przy użyciu
						algorytmu Euklidesa.
 parametry:				a - pierwsza liczba
						b - druga liczba
 zwracany typ i opis:	uint - liczba całkowita, która jest
						NWD liczb a i b
 autor:					01234567890
 *************************************************************/
uint nwd(uint a, uint b) {
	while (a != b) {
		if (a > b)
			a -= b;
		else
			b -= a;
	}

	return a;
}