var washingMachine = new WashingMachine();
var vacuumCleaner  = new VacuumCleaner();

Console.WriteLine("Podaj numer prania 1..12");
var num = int.Parse(Console.ReadLine() ?? "0");
if (washingMachine.SetWashingProgram(num) != 0)
	Console.WriteLine("Program został ustawiony");
else
	Console.WriteLine("Podano niepoprawny numer programu");

vacuumCleaner.on();
vacuumCleaner.on();
vacuumCleaner.on();
vacuumCleaner.ShowMessage("Odkurzacz wyładował się");
vacuumCleaner.off();

class Device {
	/*************************************************************
	  Nazwa:				ShowMessage
	  Opis:					Wyświetla do konsoli podany tekst z parametru
	  Parametry:			message - Tekst do wyświetlenia
	  Zwracany typ i opis:	brak
	  Autor:				01234567890
	*************************************************************/
	public void ShowMessage(string message) {
		Console.WriteLine(message);
	}
}

class WashingMachine : Device {
	private int _washingProgram = 0;

	public int SetWashingProgram(int washingProgram) {
		if (washingProgram is > 1 and <= 12) {
			_washingProgram = washingProgram;
		} else {
			_washingProgram = 0;
		}

		return _washingProgram;
	}
}

class VacuumCleaner : Device {
	private bool _status = false;

	public void on() {
		if (_status)
			return;

		_status = true;
		ShowMessage("Odkurzacz włączono");
	}

	public void off() {
		if (!_status)
			return;

		_status = false;
		ShowMessage("Odkurzacz wyłączono");
	}
}