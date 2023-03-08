namespace Bankmanager_2 {
	internal class Program {
		static void Main(string[] args) {
			static void SimuleerOverdracht(Rekening rekening1, Rekening rekening2) {
				Random _ = new Random();
				rekening2.StortGeld(rekening1.HaalGeldAf(_.Next(5, 21)));
				rekening1.StortGeld(rekening2.HaalGeldAf(_.Next(5, 21)));
				rekening2.StortGeld(rekening1.HaalGeldAf(_.Next(5, 21)));
				rekening1.StortGeld(rekening2.HaalGeldAf(_.Next(5, 21)));
				rekening2.StortGeld(rekening1.HaalGeldAf(_.Next(5, 21)));
			}

			static Rekening CreeerTienerRekening(string naam) {
				Random _ = new Random();
				Rekening rekening = new Rekening();
				rekening.NaamKlant = naam;
				rekening.RekeningNummer = Convert.ToString(_.Next(1000, 10000));
				rekening.balans = 50;
				return rekening;
			}

			Rekening rekening1 = CreeerTienerRekening("A");
			Rekening rekening2 = CreeerTienerRekening("A");

			rekening1.ToonInfo();
			rekening2.ToonInfo();

			SimuleerOverdracht(rekening1, rekening2);
			rekening1.ToonInfo();
			rekening2.ToonInfo();
		}
	}
}