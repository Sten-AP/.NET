namespace Ziekenhuis {
	internal class Patient {
		public string naam { get; set; }
		public int aantalUur { get; set; }
		private int kosten { get; set; }

		public Patient(string naam, int aantalUur) {
			this.naam = naam;
			this.aantalUur = aantalUur;
		}

		public virtual double BerekenKost() {
			return 50 + 20 * aantalUur;
		}

		public void ToonInfo() {
			Console.WriteLine($"Naam: {naam}\t Kosten: {BerekenKost()}");
		}

	}
}
