namespace Speelkaarten {
	internal class Program {
		static void Main(string[] args) {
			List<Speelkaart> speelkaarten = new List<Speelkaart>();

			foreach (suite i in Enum.GetValues(typeof(suite))) {
				for (int j = 1; j < 14; j++) {
					speelkaarten.Add(new Speelkaart(j, i));
				}
			}

			foreach (var kaart in speelkaarten) {
				kaart.kaartInfo();
			}

			Console.WriteLine();
			random_kaart(speelkaarten);
			Console.WriteLine();

			foreach (var kaart in speelkaarten) {
				kaart.kaartInfo();
			}

		}
		static void random_kaart(List<Speelkaart> speelkaarten) {
			Random r = new Random();
			int index = r.Next(0, speelkaarten.Count);
			speelkaarten[index].kaartInfo();
			speelkaarten.RemoveAt(index);
		}
	}
}