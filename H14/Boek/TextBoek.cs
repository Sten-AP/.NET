namespace Boek {
	internal class TextBoek: Boek {
		public int GradenLevel { get; set; }
		public override double Prijs {
			get { return base.Prijs; }
			set {
				if (value >= 20 && value <= 80)
					base.Prijs = value;
			}
		}

		public TextBoek(long isbn, string titel, string auteur, double prijs, int gradenLevel) : base(isbn, titel, auteur, prijs) {
			GradenLevel = gradenLevel;
		}
	}
}
