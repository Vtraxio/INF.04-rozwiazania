var arrayOps = new ArrayOperations(21);

arrayOps.DisplayElements();

var idx = arrayOps.FindElement(69);
if (idx != -1)
	Console.WriteLine($"Wartość 69 jest w indexie {idx}");

Console.WriteLine($"Razem nieparzystych {arrayOps.PrintOddAndReturn()}");
Console.WriteLine($"Średnia wszystkich elementów: {arrayOps.Average()}");

class ArrayOperations {
	private int[] _array;
	private int   _arrayElements;

	public ArrayOperations(int arrayElements) {
		_arrayElements = arrayElements;
		var random = new Random();

		_array = new int[_arrayElements];

		for (var i = 0; i < _arrayElements; i++) {
			_array[i] = random.Next(1, 1001);
		}
	}

	public void DisplayElements() {
		for (var i = 0; i < _arrayElements; i++) {
			Console.WriteLine($"{i}: {_array[i]}");
		}
	}

	public int FindElement(int element) {
		for (var i = 0; i < _arrayElements; i++) {
			if (_array[i] == element)
				return i;
		}

		return -1;
	}

	public int PrintOddAndReturn() {
		var count = 0;

		Console.WriteLine("Liczby nieparzyste:");
		for (var i = 0; i < _arrayElements; i++) {
			if (_array[i] % 2 == 1) {
				count++;
				Console.WriteLine(_array[i]);
			}
		}

		return count;
	}

	public int Average() {
		var sum = 0;

		for (var i = 0; i < _arrayElements; i++) {
			sum += _array[i];
		}

		return sum / _arrayElements;
	}
}