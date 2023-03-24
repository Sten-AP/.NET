namespace Digitale_kluis {
	internal class DigitaleKluis {
		public DigitaleKluis(int c) {
			Code = c;
		}
		private int code;
		public int Code { get { if (CanShowcode) return code; return -666; } private set { code = value; } }
		public bool CanShowcode { get; set; } = true;
		public int CodeLevel { get { return code / 1000; } }
		private int aantalPogingen;

		public bool tryCode(int getal) {
			if (aantalPogingen < 10) {
				aantalPogingen++;
				if (getal == -666) {
					Console.WriteLine("CHEATER");
					return false;
				}
				if (Code == getal) {
					Console.WriteLine($"Deze code is geldig. Aantalpogingen = {aantalPogingen}.");
					return true;
				}
				Console.WriteLine("Geen geldige code.");
				return false;
			}
			Console.WriteLine("Je hebt je 10 pogingen opgebruikt. Sorry.");
			return false;
		}

		public static void BruteForce(DigitaleKluis testKluis) {
			Random _ = new Random();
			for (int i = 0; i < 10; i++) {
				if (testKluis.tryCode(_.Next(2330, 2350))) break;
			}
		}
	}
}
