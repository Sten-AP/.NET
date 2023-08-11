namespace Speelkaarten {
	public enum suite { Schoppen = 0, Harten, Klaveren, Ruiten }
	public class Speelkaart {
		public int getal { get; set; }
		public suite kleur { get; set; }

		public Speelkaart(int g, suite k) {
			getal = g;
			kleur = k;
		}

		public void kaartInfo() {
			Console.WriteLine($"{kleur}, {getal}");
		}
	}
}
