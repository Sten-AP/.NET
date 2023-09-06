namespace Ziekenhuis {
	internal class VerzekerdePatient : Patient {
		public VerzekerdePatient(string naam, int aantalUur) : base(naam, aantalUur) { }

		public override double BerekenKost() {
			return base.BerekenKost() / 1.1;
		}
	}
}
