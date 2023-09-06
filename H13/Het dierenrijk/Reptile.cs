namespace Het_dierenrijk {
	internal class Reptile : Animal {
		public int AantalSchubben { get; set; }

		public Reptile(int AS, int B) : base(B) {
			AantalSchubben = AS;
		}

		public override void ToonInfo() {
			Console.WriteLine($"- Aantal schubben: {AantalSchubben}");
			base.ToonInfo();
		}
	}
}
