namespace Money__money__money {
	internal class SpaarRekening: Rekening {
		public override double BerekenRente() {
			return base.rekening + (base.rekening * (2.0 / 100));
		}
	}
}
