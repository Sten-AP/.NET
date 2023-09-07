namespace Een_eigen_huis {
	public class Kamer {
		public double Oppervlakte;
		public string Naam;
		public virtual double Prijs { get { return 400; } }

		public Kamer(double oppervlakte, string naam) {
			Oppervlakte = oppervlakte;
			Naam = naam;
		}
	}
}
