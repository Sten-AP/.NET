namespace Pokédex {
	internal class Program {
		static void Main(string[] args) {
			Random r = new Random();
			int keuze = 0;
			Pokédex pokedex = new Pokédex();

			while (keuze != 5) {
				Console.WriteLine("" +
					"1. Voeg Pokémon toe.\n" +
					"2. Toon Pokédex.\n" +
					"3. Remove random.\n" +
					"4. Verwijder alles.\n" +
					"5. Stoppen.");
				Console.Write("Keuze: ");
				keuze = int.Parse(Console.ReadLine());
				Console.WriteLine();

				if (keuze == 1) {
					pokedex.toevoegen(new Pokémon(r.Next(5, 11), r.Next(5, 11), r.Next(5, 11), r.Next(5, 11), r.Next(5, 11), r.Next(5, 11)));
				}
				else if (keuze == 2) {
					pokedex.toon_pokedex();
				}
				else if (keuze == 3) {
					pokedex.verwijder_random();
				}
				else if (keuze == 4) {
					pokedex.verwijder_alles();
				}
				Console.WriteLine();
			}
		}
	}
}