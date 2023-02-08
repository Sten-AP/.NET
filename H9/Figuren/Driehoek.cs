public class Driehoek {
	private int basis;
	private int hoogte;

	public int Basis {
		get { return basis; }
		set { if (value >= 1) basis = value; }
	}

	public int Hoogte {
		get { return hoogte; }
		set { if (value >= 1) hoogte = value; }
	}

	public void toonOppervlakte() {
		Console.WriteLine(basis * hoogte / 2);
	}
}

