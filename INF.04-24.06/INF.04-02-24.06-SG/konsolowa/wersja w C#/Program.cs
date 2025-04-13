var songsStr = File.ReadAllText("Data.txt");

var songs = LoadSongsFromString(songsStr);
Display(songs);

/**************************************************************
  Nazwa funkcji:	Load Songs From String
  Opis funkcji:		Zamienia ciąg znaków z pliku na listę Piosenek.
  Parametry:		Songs - ciąg znaków, z którego trzeba wyciągnąć listę piosenek.
  Zwracany typ:		List<Song> - Lista wszystkich piosenek, które zostały wyciągnięte z parametru.
  Autor:			01234567890
**************************************************************/
List<Song> LoadSongsFromString(string songs) {
	var songsListStr = songs.Split("\r\n\r\n");

	return songsListStr.Select(album => {
		var data = album.Split("\r\n");

		return new Song(data[0], data[1], uint.Parse(data[2]), uint.Parse(data[3]), uint.Parse(data[4]));
	}).ToList();
}

void Display(List<Song> list) {
	foreach (var song in list) {
		Console.WriteLine(song.artist);
		Console.WriteLine(song.album);
		Console.WriteLine(song.songNumber);
		Console.WriteLine(song.year);
		Console.WriteLine(song.downloadNumber);
		Console.WriteLine();
	}
}

record Song(string artist, string album, uint songNumber, uint year, uint downloadNumber);