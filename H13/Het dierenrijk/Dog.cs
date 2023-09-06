namespace Het_dierenrijk {
	internal class Dog : Mammal {
		public string soort { get; set; }

		public Dog(string S, bool IZ, int B) : base(IZ, B) {
			soort = S;
		}

		public override void ToonInfo() {
			Console.WriteLine($"Hond\n- Soort: {soort}");
			base.ToonInfo();
		}
	}
}
