namespace Moederbord {
	public class RAM: Merk {
		public int Clocksnelheid;
		public int Geheugen;

		public RAM(string naam, int clocksnelheid, int geheugen) : base(naam) {
			Clocksnelheid = clocksnelheid;
			Geheugen = geheugen;
		}
	}
}
