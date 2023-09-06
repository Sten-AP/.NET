namespace Het_dierenrijk {
	internal class Iguana : Reptile {
		public string kleur { get; set; }

		public Iguana(string K, int AS, int B) : base(AS, B) {
			kleur = K;
		}

		public override void ToonInfo() {
			Console.WriteLine($"Iguana\n- Kleur: {kleur}");
			base.ToonInfo();
		}
	}
}
