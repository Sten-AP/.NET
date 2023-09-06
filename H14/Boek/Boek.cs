namespace Boek {
	internal class Boek {
		public long ISBN { get; set; }
		public string Titel { get; set; }
		public string Auteur { get; set; }

		private double prijs;
		public virtual double Prijs { get { return prijs; } set { prijs = value; } }

		public Boek() { }

		public Boek(long a, string b, string c, double d) {
			ISBN = a;
			Titel = b;
			Auteur = c;
			Prijs = d;
		}

		static Boek TelOp(Boek boek1, Boek boek2) {
			Boek result = new Boek();

			result.Titel = $"Omnibus van {boek1.Auteur},{boek2.Auteur}";
			result.Prijs = (boek1.Prijs + boek2.Prijs) / 2;

			return result;
		}

	}
}
