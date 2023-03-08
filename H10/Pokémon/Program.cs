namespace Pokémon {
	internal class Program {
		static void Main(string[] args) {
			Pokémon Pokemon = new Pokémon();

			Pokemon.HP_Base = 39;
			Pokemon.Attack_Base = 52;
			Pokemon.Defense_Base = 43;
			Pokemon.SpAttack_Base = 60;
			Pokemon.SpDefense_Base = 50;
			Pokemon.Speed_Base = 65;

			Pokemon.Naam = "Charmander";
			Pokemon.Type = Types.fire;
			Pokemon.Nummer = 4;

			//while (Pokemon.Level <= 100) {
			//	Console.WriteLine("Huidig level:\t" + Pokemon.Level);
			//	Console.WriteLine("\tHP:\t\t" + Pokemon.HP_Full);
			//	Console.WriteLine("\tAttack:\t\t" + Pokemon.Attack_Full);
			//	Console.WriteLine("\tDefense:\t" + Pokemon.Defense_Full);
			//	Console.WriteLine("\tSpAttack:\t" + Pokemon.SpAttack_Full);
			//	Console.WriteLine("\tSpDefense:\t" + Pokemon.SpDefense_Full);
			//	Console.WriteLine("\tSpeed:\t\t" + Pokemon.Speed_Full +"\n");

			//	Pokemon.VerhoogLevel();
			//}

			Pokemon.ShowStats();
			Pokemon.VerhoogLevel(10);
			Pokemon.ShowStats();

		}
	}
}