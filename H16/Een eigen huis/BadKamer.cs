namespace Een_eigen_huis {
	internal class BadKamer: Kamer {
		public override double Prijs { get { return 500; } }

		public BadKamer(double oppervlakte, string naam) : base(oppervlakte, naam) { }
	}
}
