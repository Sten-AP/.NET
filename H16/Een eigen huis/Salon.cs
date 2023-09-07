namespace Een_eigen_huis {
	internal class Salon: Kamer {
		public bool SchouwAanwezig = false;
		public override double Prijs { get { if (SchouwAanwezig) return 500; return 300; } }

		public Salon(double oppervlakte, string naam, bool schouwAanwezig) : base(oppervlakte, naam) {
			SchouwAanwezig = schouwAanwezig;
		}

	}
}
