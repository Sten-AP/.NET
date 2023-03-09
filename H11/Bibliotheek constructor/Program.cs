namespace Bibliotheek_constructor {
	internal class Program {
		static void Main(string[] args) {
			BibBoek boek1 = new BibBoek(DateTime.Now.AddDays(3));
			boek1.gegevens();
			BibBoek boek2 = new BibBoek();
			boek2.gegevens();
		}
	}
}