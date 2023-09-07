namespace Carbon_Footprint {
	public enum AutoMerk { BMW, Volvo, Audi, Tesla }
	internal class Auto: ICarbonFootPrint {
		public AutoMerk Merk { get; set; }
		private int Factor = 1;

		public int BerekenFootprint() {
			switch (Merk) {
				case AutoMerk.BMW:
				return 10 + Factor;
				case AutoMerk.Volvo:
				return 12 + Factor;
				case AutoMerk.Audi:
				return 14 + Factor;
				case AutoMerk.Tesla:
				return 0 + Factor;
			}
			return 0;
		}

		public void VerlaagFootprint() {
			if (Factor > 0)
				Factor--;
		}
	}
}
