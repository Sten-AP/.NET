public class BibBoek {
	public string ontlener = "onbekend";
	public DateTime uitgeleend {
		private get { return uitgeleend; }
		set { uitgeleend = DateTime.Now; }
	}

	public DateTime inLeverDatum { 
		set { inLeverDatum =  } 
	}

	public void VerlengTermijn(int termijn) {

		gegevens();
	}

	private void gegevens() {
		Console.WriteLine($"Ontlener:\t{ontlener}\nUitgeleend:\t{uitgeleend}\nInleverdatum:\t{inLeverDatum}");
	}
}