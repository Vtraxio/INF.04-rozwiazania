Console.Write("Wpisz jakiś tekst: ");
var str = Console.ReadLine() ?? "";
Console.WriteLine($"Liczba samogłosek: {StringFunctions.CountVowels(str)}");
Console.WriteLine($"Tekst bez duplikatów: {StringFunctions.RemoveDuplicate(str)}");

/**************************************************************
  Klasa:	StringFunctions
  Opis:		Reprezentuje małą bibliotekę tekstową
  Metody:	CountVowels - zwraca liczbę zamogłosek
			RemoveDuplicate - zwraca tekst z parametru bez duplikatów obok siebie.
  Autor:	01234567890
**************************************************************/
class StringFunctions {
	public static int CountVowels(string str) {
		var vowels = "aąeęiouóy";

		if (str is null or "")
			return 0;

		return str.ToCharArray().Count(x => vowels.Contains(char.ToLower(x)));
	}

	public static string RemoveDuplicate(string str) {
		var toRet = string.Empty;
		
		if (str is null or "")
			return string.Empty;

		var last = '\0';
		foreach (var c in str) {
			if (c == last)
				continue;

			toRet += c;
			last  =  c;
		}

		return toRet;
	}
}