namespace Politiek {
	internal class Program {
		static void Main(string[] args) {
			President president = new President() { Naam = "Sten" };
			List<Minister> ministers = new List<Minister>();
			ministers.Add(new Minister() { Naam = "Bruno" });
			ministers.Add(new Minister() { Naam = "Freya" });
			ministers.Add(new Minister() { Naam = "Peter" });
			ministers.Add(new Minister() { Naam = "Ann" });

			Land mijnLand = new Land();
			mijnLand.MaakRegering(president, ministers);
			mijnLand.MaakRegering(president, ministers); //Moet error geven
			Console.WriteLine(president.Naam);
			for (int i = 0; i < 4; i++) {
				Console.WriteLine("Weer een jaar verder");
				mijnLand.JaarVerder();
			}
			VerkiezingsUitslag uitslag = new VerkiezingsUitslag();
		}
	}
}