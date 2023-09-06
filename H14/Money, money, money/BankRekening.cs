namespace Money__money__money {
	internal class BankRekening: Rekening {
		public override double BerekenRente() {
			if (base.rekening >= 100) return base.rekening + (base.rekening * (5.0 / 100));
			return base.rekening;
		}
	}
}
