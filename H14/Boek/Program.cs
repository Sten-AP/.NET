namespace Boek {
	internal class Program {
		static void Main(string[] args) {
			TextBoek boek1 = new TextBoek(5135384351581, "Gevaarlijke man", "Jan", 50, 2);
			KoffietafelBoek boek2 = new KoffietafelBoek(146846846857, "Gevaarlijke vrouw", "Piet", 80);
			Boek boek3 = new Boek(646246742857, "Gevaarlijke jongen", "Mieke", 100);
			Console.WriteLine(boek1);
			Console.WriteLine(boek2);
			Console.WriteLine(boek3);
			Console.WriteLine(Boek.TelOp(boek1, boek2));
		}
	}
}