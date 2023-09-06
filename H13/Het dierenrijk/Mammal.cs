namespace Het_dierenrijk {
	internal class Mammal : Animal {
		public bool isZwanger { get; set; }

		public Mammal(bool IZ, int B) : base(B) {
			isZwanger = IZ;
		}

		public override void ToonInfo() {
			Console.WriteLine($"- Zwanger: {isZwanger}");
			base.ToonInfo();
		}
	}
}
