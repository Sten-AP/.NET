namespace Boek {
	internal class TextBoek: Boek {
		public int GradenLevel { get; set; }

		public TextBoek(long a, string b, string c, double d, int e) : base(a, b, c, d) {
			GradenLevel = e;
		}
	}
}
