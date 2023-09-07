namespace Een_eigen_huis {
	internal class Gang: Kamer {
		public override double Prijs { get { return Oppervlakte * 10; } }

		public Gang(double oppervlakte, string naam) : base(oppervlakte, naam) { }
	}
}
