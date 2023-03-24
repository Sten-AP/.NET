namespace Pokémon_2 {
	internal class Program {
		static void Main(string[] args) {
			Pokémon pokemon1 = new Pokémon();
			Pokémon pokemon2 = new Pokémon(45, 42, 50, 65, 34, 67);
			Pokémon pokemon3 = new Pokémon() { HP_Base=40, Naam="Pikachu"};

		}
	}
}