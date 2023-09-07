namespace Carbon_Footprint {
	internal class Program {
		static void Main(string[] args) {
			Huis huis1 = new Huis() { Volume = 500 };
			Huis huis2 = new Huis() { Volume = 750 };
			Fabriek fabriek1 = new Fabriek() { Werknemers = 100 };
			Fabriek fabriek2 = new Fabriek() { Werknemers = 500 };
			Auto auto1 = new Auto() { Merk = AutoMerk.Audi };
			Auto auto2 = new Auto() { Merk = AutoMerk.Tesla };
			Plant plant1 = new Plant();
			Plant plant2 = new Plant();

			List<Object> objecten = new List<Object>();
			objecten.Add(huis1);
			objecten.Add(huis2);
			objecten.Add(fabriek1);
			objecten.Add(fabriek2);
			objecten.Add(auto1);
			objecten.Add(auto2);
			objecten.Add(plant1);
			objecten.Add(plant2);

			int som = 0;
			int max = -1;
			int maxindex = -1;

			for (int i = 0; i < objecten.Count; i++) {
				var temp = objecten[i] as ICarbonFootPrint;
				if (temp != null) {
					int print = temp.BerekenFootprint();
					Console.WriteLine($"{objecten[i].GetType()}: {print}");
					som += print;
					if (print > max) {
						max = print;
						maxindex = i;
					}
				}
			}
			Console.WriteLine($"Gemiddelde footprint is {som / objecten.Count}");
			if (maxindex > -1)
				Console.WriteLine($"{objecten[maxindex]} op positie {maxindex} heeft grootste footprint {max}");
		}
	}
}