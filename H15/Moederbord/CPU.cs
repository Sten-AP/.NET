namespace Moederbord {
	public class CPU: Merk {
		public double Clocksnelheid;
		public int Cores;

		public CPU(string naam, double clocksnelheid, int cores) : base(naam) {
			Clocksnelheid = clocksnelheid;
			Cores = cores;
		}
	}
}
