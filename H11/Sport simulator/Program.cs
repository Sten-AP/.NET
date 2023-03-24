namespace Sport_simulator {
	internal class Program {
		static void Main(string[] args) {
			Sportspeler speler1 = new Sportspeler();
			Sportspeler speler2 = new Sportspeler();

			speler1.StelIn("Jan", 13, false, false, "a");
			speler2.StelIn("Piet", 5, false, true, "b");

			Sportspeler.SimuleerWedstrijd(speler1, speler2);
			Sportspeler.BesteSpeler(speler1, speler2);
		}
	}
}