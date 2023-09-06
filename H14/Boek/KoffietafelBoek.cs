namespace Boek {
	internal class KoffietafelBoek: Boek {
		public override double Prijs {
			get { return base.Prijs; }
			set {
				if (value >= 35 && value < 100) {
					base.Prijs = value;
				}
			}
		}
		public KoffietafelBoek(long isbn, string titel, string auteur, double prijs) : base(isbn, titel, auteur, prijs) { }
	}
}
