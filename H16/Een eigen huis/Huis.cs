namespace Een_eigen_huis {
	internal class Huis {
		List<Kamer> Kamers;
		public double TotaalPrijs { get { return BerekenPrijs(); } }

		public Huis(List<Kamer> kamers) {
			Kamers = kamers;
		}

		private double BerekenPrijs() {
			double prijs = 0;
			foreach (Kamer kamer in Kamers) {
				prijs += kamer.Prijs;
			}
			return prijs;
		}
	}
}
