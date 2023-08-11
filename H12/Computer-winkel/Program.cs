namespace Computer_winkel {
	internal class Program {
		static void Main(string[] args) {
			List<Computeronderdeel> computeronderdelen = new List<Computeronderdeel>();

			for (int i = 0; i < 100; i++) {
				computeronderdelen.Add(new Computeronderdeel());
			}

			ToonInfo_Alle(computeronderdelen);
			ToonInfo_Boven_400(computeronderdelen);
			ToonInfo_In_Doos(computeronderdelen);
			ToonInfo_Even_ID_En_Onder_200(computeronderdelen);
			Delete_In_Een_Doos(computeronderdelen);
			Delete_onder_200(computeronderdelen);

			Console.WriteLine("\n\n\nInformatie van de overgebleven onderdelen:");
			ToonInfo_Alle(computeronderdelen);
		}

		static void ToonInfo_Alle(List<Computeronderdeel> computeronderdelen) {
			Console.WriteLine("Alle onderdelen.");
			foreach (Computeronderdeel computeronderdeel in computeronderdelen) computeronderdeel.ToonInfo();
		}

		static void ToonInfo_Boven_400(List<Computeronderdeel> computeronderdelen) {
			Console.WriteLine("\nAlle onderdelen met de prijs boven de 400.");
			foreach (Computeronderdeel computeronderdeel in computeronderdelen) {
				if (computeronderdeel.Prijs > 400) computeronderdeel.ToonInfo();
			}
		}

		static void ToonInfo_In_Doos(List<Computeronderdeel> computeronderdelen) {
			Console.WriteLine("\nAlle onderdelen in een doos.");
			foreach (Computeronderdeel computeronderdeel in computeronderdelen) {
				if (computeronderdeel.InDoos) computeronderdeel.ToonInfo();
			}
		}

		static void ToonInfo_Even_ID_En_Onder_200(List<Computeronderdeel> computeronderdelen) {
			Console.WriteLine("\nAlle onderdelen met een even ID en prijs onder de 200.");
			foreach (Computeronderdeel computeronderdeel in computeronderdelen) {
				if (computeronderdeel.ID % 2 == 0 && computeronderdeel.Prijs < 200) computeronderdeel.ToonInfo();
			}
		}

		static void Delete_In_Een_Doos(List<Computeronderdeel> computeronderdelen) {
			string input = "";
			while (input != "y" && input != "yes" && input != "n" && input != "no") {
				Console.WriteLine("\n\n\nWil je alle onderdelen die in een doos zitten verwijderen? (y/n)");
				input = Console.ReadLine();
			}

			if (input == "y" || input == "yes") {
				for (int i = 0; i < computeronderdelen.Count; i++) {
					if (computeronderdelen[i].InDoos) computeronderdelen.Remove(computeronderdelen[i]);
				}
			}
		}

		static void Delete_onder_200(List<Computeronderdeel> computeronderdelen) {
			string input = "";
			while (input != "y" && input != "yes" && input != "n" && input != "no") {
				Console.WriteLine("\n\n\nWil je alle onderdelen met een prijs lager dan 100 verwijderen? (y/n)");
				input = Console.ReadLine();
			}

			if (input == "y" || input == "yes") {
				for (int i = 0; i < computeronderdelen.Count; i++) {
					if (computeronderdelen[i].Prijs < 100) computeronderdelen.Remove(computeronderdelen[i]);
				}
			}
		}
	}
}