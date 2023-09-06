namespace Money__money__money {
	abstract class Rekening {
		private double R = 0;
		public double rekening {
			get { return R; }
		}

		public void VoegGeldToe(int geld) {
			R += geld;
		}
		public void HaalGeldAf(int geld) {
			R -= geld;
		}

		public abstract double BerekenRente();
	}
}
