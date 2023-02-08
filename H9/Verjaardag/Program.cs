Console.WriteLine("Wanneer is je verjaardag (d/m, bv 18/03)");
string verjaardag = Console.ReadLine();

DateTime datumVerjaardag = DateTime.Parse(verjaardag);
DateTime datumNu = DateTime.Today;

TimeSpan verschil = datumVerjaardag - datumNu;

Console.WriteLine($"Je bent over {verschil.Days} dagen jarig op een {datumVerjaardag.DayOfWeek}.");