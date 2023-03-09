namespace Meetlat_constructor {
	internal class Program {
		static void Main(string[] args) {
			Meetlat meetlat = new Meetlat(10);
			Console.WriteLine(meetlat.LengteInCm);
			Console.WriteLine(meetlat.LengteInM);
			Console.WriteLine(meetlat.LengteInKm);
			Console.WriteLine(meetlat.LengteInVoet);
		}
	}
}