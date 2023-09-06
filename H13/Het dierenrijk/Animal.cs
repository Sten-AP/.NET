namespace Het_dierenrijk {
	public class Animal {
		public int breedte { get; set; }

		public Animal(int B) {
			breedte = B;
		}

		public virtual void ToonInfo() {
			Console.WriteLine($"- Breedte: {breedte}cm");
		}
	}
}
