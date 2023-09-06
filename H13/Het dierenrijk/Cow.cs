namespace Het_dierenrijk {
	internal class Cow : Mammal {
		public int aantalVlekken { get; set; }

		public Cow(int AV, bool IZ, int B) : base(IZ, B) {
			aantalVlekken = AV;
		}

		public override void ToonInfo() {
			Console.WriteLine($"Koe\n- Aantal vlekken: {aantalVlekken}");
			base.ToonInfo();
		}
	}
}
