int[] weights = [1, 3, 7, 9, 1, 3, 7, 9, 1, 3];

Console.Write("Wpisz pesel: ");
var pesel = Console.ReadLine();
if (pesel is null or "")
	pesel = "55030101193";

Console.WriteLine(CheckGender(pesel) == 'K' ? "Kobieta" : "Mężczyzna");
Console.WriteLine(CheckValidity(pesel) ? "Pesel poprawny" : "Pesel niepoprawny");

char CheckGender(string pesel) {
	return (pesel[9] - '0') % 2 == 0 ? 'K' : 'M';
}

/**************************************************************
  Nazwa funckji:		CheckValidity
  Opis funkcji:			Sprawdza, czy numer pesel jest poprawny, wykorzystując cyfrę kontrolną.
  Parametry:			pesel - Całość numeru pesel do weryfikacji.
  Zwracany typ i opis:	bool - true jeśli pesel jest poprawny, false, jeśli nie jest
  Autor:				01234567890
**************************************************************/
bool CheckValidity(string pesel) {
	var S = pesel[..10].ToCharArray().Select((c, i) => (c - '0') * weights[i]).Sum();
	var M = S % 10;

	var R = M == 0 ? 0 : 10 - M;

	return R == pesel[10] - '0';
}