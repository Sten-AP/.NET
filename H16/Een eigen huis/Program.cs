namespace Een_eigen_huis {
	internal class Program {
		static void Main(string[] args) {
			BadKamer badkamer1 = new BadKamer(200, "Badkamer Kinderen");
			BadKamer badkamer2 = new BadKamer(200, "Badkamer Ouders");
			Salon salon = new Salon(400, "Woonkamer", true);
			Gang gang = new Gang(200, "Inkomhal");

			List<Kamer> kamers = new List<Kamer>();

			kamers.Add(badkamer1);
			kamers.Add(badkamer2);
			kamers.Add(salon);
			kamers.Add(gang);

			Huis huis = new Huis(kamers);
			Console.WriteLine(huis.TotaalPrijs);
		}
	}
}