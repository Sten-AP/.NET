namespace Bankmanager_2 {

	public enum RekeningStaat {
		Geldig,
		Geblokkeerd
	}

	public class Rekening {
		public string NaamKlant;
		public string RekeningNummer;

		private int Balans = 1000;
		public int balans {
			get { return Balans; }
			set { Balans = value; }
		}

		public RekeningStaat Staat {
			get;
			private set;
		} = RekeningStaat.Geldig;

		public int HaalGeldAf(int aantal) {
			if (Staat == RekeningStaat.Geldig) {
				if (aantal > Balans) {
					VeranderStaat();
					Console.WriteLine("Rekening leeg nu.");
					int overschot = Balans;
					Balans = 0;
					return overschot;
				}
				Balans -= aantal;
				return aantal;
			}
			Console.WriteLine("Gaat niet. Rekening geblokkeerd.");
			return 0;
		}

		public void StortGeld(int aantal) {
			if (Staat == RekeningStaat.Geldig) Balans += aantal;
			else Console.WriteLine("Gaat niet. Rekening geblokkeerd.");
		}

		public RekeningStaat VeranderStaat() {
			if (Staat == RekeningStaat.Geldig) return Staat = RekeningStaat.Geblokkeerd;
			return Staat = RekeningStaat.Geldig;
		}

		public void ToonInfo() {
			Console.Write($"Klant:\t\t{NaamKlant}\nRekeningnummer:\t{RekeningNummer}\nBalans:\t\t");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"{balans}\n");
			Console.ResetColor();
		}
	}
}