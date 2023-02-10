public class Waterpolospeler {
	private string naam;
	private string spelerNaam { set { naam = value; } get { return naam; } }
	private int mutsNummer { set { } }
	private bool isDoelman { set { } }
	private bool isReserve { set { } }
	private string reeks { set { } }

	public void GooiBal() {
		Console.WriteLine($"Ik ({spelerNaam}) gooi de bal.");
	}

	public void Watertrappen() {
		Console.WriteLine($"Ik ({spelerNaam}) zwem naar de bal.");
	}

	public void StelIn(string SpelerNaam, int MutsNummer, bool IsDoelman, bool IsReserve, string Reeks) {
		spelerNaam = SpelerNaam;
		mutsNummer = MutsNummer;
		isDoelman = IsDoelman;
		isReserve = IsReserve;
		reeks = Reeks;
	}
}