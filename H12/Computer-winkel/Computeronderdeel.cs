namespace Computer_winkel {
	public class Computeronderdeel {
		private static Random r = new Random();
		public int Prijs { get; set; }
		public int ID { get; set; }
		public bool InDoos { get; set; }

		public Computeronderdeel() {
			Prijs = r.Next(0, 1001);
			ID = r.Next(100, 1000);
			if (r.Next() % 2 == 0) InDoos = true;
		}

		public void ToonInfo() {
			Console.WriteLine($"Prijs: {Prijs}\tID: {ID}\t     InDoos: {InDoos}");
		}
	}
}
