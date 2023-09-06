namespace Money__money__money {
	internal class ProRekening: SpaarRekening {
		public override double BerekenRente() {
			return base.BerekenRente() + (int)rekening / 1000 * 10;
		}
	}
}
