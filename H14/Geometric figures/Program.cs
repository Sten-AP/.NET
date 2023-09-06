namespace Geometric_figures {
	internal class Program {
		static void Main(string[] args) {
			Console.Write("Rechthoek 20x10: ");
			Rechthoek rechthoek = new Rechthoek() { Hoogte = 20, Breedte = 10 };
			Console.WriteLine(rechthoek.BerekenOppervlakte());
			Console.Write("Vierkant 20x10: ");
			Vierkant vierkant1 = new Vierkant(20, 10);
			Console.WriteLine(vierkant1.BerekenOppervlakte());
			Console.Write("Vierkant 20: ");
			Vierkant vierkant2 = new Vierkant(20);
			Console.WriteLine(vierkant2.BerekenOppervlakte());
			Console.Write("Driehoek 25x10: ");
			Driehoek driehoek = new Driehoek() { Hoogte = 25, Breedte = 10 };
			Console.WriteLine(driehoek.BerekenOppervlakte());
		}
	}
}