namespace Carbon_Footprint {
	internal class Huis: ICarbonFootPrint {
		public int Volume { get; set; }
		private double Factor = 10;

		public int BerekenFootprint() {
			return (int)(Volume * Factor);
		}

		public void VerlaagFootprint() {
			if (BerekenFootprint() > 1) {
				Factor -= 0.1;
			}
		}
	}
}
