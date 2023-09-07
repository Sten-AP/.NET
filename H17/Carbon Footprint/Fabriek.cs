namespace Carbon_Footprint {
	internal class Fabriek: ICarbonFootPrint {
		public int Werknemers { get; set; }
		private double Factor = 100;

		public int BerekenFootprint() {
			return (int)(Werknemers * Factor);
		}

		public void VerlaagFootprint() {
			if (BerekenFootprint() > 5) {
				Factor--;
			}
		}
	}
}
