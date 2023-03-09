namespace Bibliotheek_constructor {
	public class BibBoek {
		public string ontlener = "onbekend";

		public DateTime uitgeleend;

		private int aantalDagen = 14;
		public DateTime inLeverDatum {
			get { return uitgeleend.AddDays(aantalDagen); }
		}

		public BibBoek() {
			uitgeleend = DateTime.Now;
		}
		public BibBoek(DateTime datum) {
			uitgeleend = datum;
		}
		public void verlengTermijn(int aantal) {
			aantalDagen += aantal;
		}

		public void gegevens() {
			Console.WriteLine($"Ontlener:\t{ontlener}\nUitgeleend:\t{uitgeleend.ToShortDateString()}\nInleverdatum:\t{inLeverDatum.ToShortDateString()}");
		}
	}
}