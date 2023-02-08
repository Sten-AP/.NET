public class Waterpolospeler {
	private string spelerNaam { set { } }
	private int mutsNummer { set { } }
	private bool isDoelman { set { } }
	private bool isReserve { set { } }
	private string reeks { set { } }

	public void GooiBal() {

	}
	public void Watertrappen() {

	}
	public void StelIn(string SpelerNaam, int MutsNummer, bool IsDoelman, bool IsReserve, string Reeks) {
		spelerNaam = SpelerNaam;
		mutsNummer = MutsNummer;
		isDoelman = IsDoelman;
		isReserve = IsReserve;
		reeks = Reeks;
	}
}