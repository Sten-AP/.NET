using System;

namespace Pokémon_Tester {
	internal class Program {
		static void Main(string[] args) {
			Pokémon pokemon1 = new Pokémon();
			pokemon1.HP_Base = 39;
			pokemon1.Attack_Base = 52;
			pokemon1.Defense_Base = 43;
			pokemon1.SpAttack_Base = 60;
			pokemon1.SpDefense_Base = 50;
			pokemon1.Speed_Base = 65;
			pokemon1.Naam = "Charmander";
			pokemon1.Type = Types.fire;
			pokemon1.Nummer = 4;

			Pokémon pokemon2 = new Pokémon();
			pokemon2.HP_Base = 45;
			pokemon2.Attack_Base = 49;
			pokemon2.Defense_Base = 49;
			pokemon2.SpAttack_Base = 65;
			pokemon2.SpDefense_Base = 65;
			pokemon2.Speed_Base = 45;
			pokemon2.Naam = "Bulbasaur";
			pokemon2.Type = Types.grass;
			pokemon2.Nummer = 1;

			//Pokémon pokemon3 = new Pokémon();
			//Console.Write("HP base: ");
			//pokemon3.HP_Base = Convert.ToInt16(Console.ReadLine());
			//Console.Write("Attack base: ");
			//pokemon3.Attack_Base = Convert.ToInt16(Console.ReadLine()); 
			//Console.Write("Defense base: ");
			//pokemon3.Defense_Base = Convert.ToInt16(Console.ReadLine());
			//Console.Write("SpAttack base: ");
			//pokemon3.SpAttack_Base = Convert.ToInt16(Console.ReadLine());
			//Console.Write("SpDefense base: ");
			//pokemon3.SpDefense_Base = Convert.ToInt16(Console.ReadLine());
			//Console.Write("Speed base: ");
			//pokemon3.Speed_Base = Convert.ToInt16(Console.ReadLine());
			//Console.Write("Naam: ");
			//pokemon3.Naam = Console.ReadLine();
			//Console.Write("Level pokémon: ");
			//pokemon3.VerhoogLevel(Convert.ToInt16(Console.ReadLine())-1);

			//pokemon3.ShowStats();

			static Pokémon GeneratorPokémon() {
				Random _ = new Random();
				Pokémon pokemon = new Pokémon();
				pokemon.HP_Base = _.Next(30, 50);
				pokemon.Attack_Base = _.Next(30, 60);
				pokemon.Defense_Base = _.Next(30, 60);
				pokemon.SpAttack_Base = _.Next(30,70);
				pokemon.SpDefense_Base = _.Next(30,70);
				pokemon.Speed_Base = _.Next(40,70);
				return pokemon;
			}

			static int Battle(Pokémon poke1, Pokémon poke2) {
				if (poke1 == null || poke2 == null) throw new ArgumentNullException();
				poke1.ShowStats();
				poke2.ShowStats();

				if (poke1.Average_Full > poke2.Average_Full) return 1;
				if (poke1.Average_Full < poke2.Average_Full) return 2;
				return 0;
			}

			int resultaat = Battle(GeneratorPokémon(), GeneratorPokémon());
			if (resultaat == 0) Console.WriteLine("Gelijkspel...");
			else Console.WriteLine($"Pokemon {resultaat} wint!");
		}
	}
}