namespace Digitale_kluis {
	internal class DigitaleKluis {
		public DigitaleKluis(int c) {
			Code = c;
		}
		private int code;
		public int Code { get { if (CanShowcode) return code; return - 666; } private set { } }
		private bool CanShowcode;
	}
}
