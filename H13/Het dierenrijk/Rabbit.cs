namespace Het_dierenrijk {
	internal class Rabbit : Mammal {
		public string kleur { get; set; }

		public Rabbit(string K, bool IZ, int B) : base(IZ, B) {
			kleur = K;
		}

		public override void ToonInfo() {
			Console.WriteLine($"Konijn\n- Kleur: {kleur}");
			base.ToonInfo();
		}
	}
}
