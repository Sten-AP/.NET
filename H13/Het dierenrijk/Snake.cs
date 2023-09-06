namespace Het_dierenrijk {
	internal class Snake : Reptile {
		public string vormen { get; set; }

		public Snake(string V, int AS, int B) : base(AS, B) {
			vormen = V;
		}

		public override void ToonInfo() {
			Console.WriteLine($"Slang\n- Vormen: {vormen}");
			base.ToonInfo();
		}
	}
}
