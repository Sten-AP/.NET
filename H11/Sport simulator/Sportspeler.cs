namespace Sport_simulator {
	public class Sportspeler {
		private string spelerNaam;
		public string SpelerNaam { get { return spelerNaam; } private set { spelerNaam = value; } }

		private int mutsNummer;
		public int MutsNummer { get { return mutsNummer; } private set { if (value > 0 && value < 14) { mutsNummer = value; } } }

		private bool isDoelman;
		public bool IsDoelman { get { return isDoelman; } private set { isDoelman = value; } }

		private bool isReserve;
		public bool IsReserve { get { return isReserve; } private set { isReserve = value; } }

		private string reeks;
		public string Reeks { get { return reeks; } private set { reeks = value; } }

		public void StelIn(string SpelerNaam, int MutsNummer, bool IsDoelman, bool IsReserve, string Reeks) {
			spelerNaam = SpelerNaam;
			mutsNummer = MutsNummer;
			isDoelman = IsDoelman;
			isReserve = IsReserve;
			reeks = Reeks;
		}

		public void GooiBal() {
			Console.WriteLine($"Ik ({spelerNaam}) gooi de bal.");
		}

		public void Watertrappen() {
			Console.WriteLine($"Ik ({spelerNaam}) zwem naar de bal.");
		}

		public void Tooninfo() {
			Console.WriteLine($"Naam: {SpelerNaam}\nMutsnummer: {MutsNummer}\nIs doelman: {IsDoelman}\nIs reserve: {IsReserve}\nReeks: {Reeks}\n");
		}

		public static void SimuleerSpeler(Sportspeler testspeler) {
			for (int i = 0; i < 3; i++) {
				testspeler.Watertrappen();

			}
			for (int i = 0; i < 3; i++) {
				testspeler.GooiBal();
			}
		}

		public static void SimuleerWedstrijd(Sportspeler speler1, Sportspeler speler2) {
			Random _ = new Random();
			if (_.Next(0, 10) < 5) Console.WriteLine($"{speler1.SpelerNaam} wint.");
			else Console.WriteLine($"{speler2.SpelerNaam} wint.");
		}

		public static Sportspeler BesteSpeler(Sportspeler speler1, Sportspeler speler2) {
			Random _ = new Random();
			if (_.Next(0, 10) < 5) return speler1;
			return speler2;
		}
	}
}