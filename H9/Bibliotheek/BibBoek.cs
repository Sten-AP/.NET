public class BibBoek {
	public string ontlener = "onbekend";

	private DateTime Uitgeleend = DateTime.Now;
	public DateTime uitgeleend {
		private get { return Uitgeleend; }
		set { Uitgeleend = value; }
	}

	private int aantalDagen = 14;
	public DateTime inLeverDatum {
		get { return Uitgeleend.AddDays(aantalDagen); }
	}

	public void verlengTermijn(int aantal) {
		aantalDagen += aantal;
	}

	public void gegevens() {
		Console.WriteLine($"Ontlener:\t{ontlener}\nUitgeleend:\t{uitgeleend.ToShortDateString()}\nInleverdatum:\t{inLeverDatum.ToShortDateString()}");
	}
}