namespace Moederbord {
	public class GPU: Merk {
		public int Clocksnelheid;
		public int Geheugen;

		public GPU(string naam, int clocksnelheid, int geheugen) : base(naam) {
			Clocksnelheid = clocksnelheid;
			Geheugen = geheugen;
		}
	}
}
