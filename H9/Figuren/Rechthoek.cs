public class Rechthoek {
	private int lengte;
	private int breedte;

	public int Lengte {
		get { return lengte; }
		set { if (value >= 1) lengte = value; }
	}

	public int Breedte {
		get { return breedte; }
		set { if (value >= 1) breedte = value; }
	}

	public void toonOppervlakte() {
		Console.WriteLine(lengte * breedte);
	}
}
