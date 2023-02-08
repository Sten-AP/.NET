public class Rekening {
	public string NaamKlant;
	public string RekeningNummer;

	private int Balans = 1000;
	public int balans {
		get { return Balans; }
	}

	public int HaalGeldAf(int aantal) {
		if (aantal > balans) {
			return aantal - Balans;
		}
		Balans -= aantal;
		return aantal;
	}

	public void StortGeld(int aantal) {
		Balans += aantal;
	}

	public void ToonInfo() {
		Console.WriteLine($"\nKlant:\t\t{NaamKlant}\nRekeningnummer:\t{RekeningNummer}\nBedrag:\t\t{balans}");
		if (Balans == 0) {
			Console.WriteLine("Rekening leeg nu.");
		}
	}
}
