namespace Pokémon_2 {
	public enum PokeNatures {
		Adamant,
		Bashful,
		Bold,
		Brave,
		Calm,
		Careful,
		Docile,
		Gentle,
		Hardy,
		Hasty,
		Impish,
		Jolly,
		Lax,
		Lonely,
		Mild,
		Modest,
		Naive,
		Naughty,
		Quiet,
		Quirky,
		Rash,
		Relaxed,
		Sassy,
		Serious,
		Timid
	}

	public enum StatTypes {
		Attack,
		Special_Attack,
		Defense,
		Special_Defense,
		Speed
	}


	public class Pokémon {
		public int HP_Base { get; set; }
		public int Attack_Base { get; private set; }
		public int Defense_Base { get; private set; }
		public int SpAttack_Base { get; private set; }
		public int SpDefense_Base { get; private set; }
		public int Speed_Base { get; private set; }

		public string Naam { get; set; }
		public StatTypes Type { get; set; }
		public int Nummer { get; set; }

		public int Level { get; private set; } = 1;

		public double Average {
			get { return (HP_Base + Attack_Base + Defense_Base + SpAttack_Base + SpDefense_Base + Speed_Base) / 6.0; }
		}
		public int Total {
			get { return HP_Base + Attack_Base + Defense_Base + SpAttack_Base + SpDefense_Base + Speed_Base; }
		}
		public int HP_Full {
			get { return ((HP_Base + 50) * Level / 50) + 10; }
		}
		public int Attack_Full {
			get { return (Attack_Base * Level / 50) + 5; }
		}
		public int Defense_Full {
			get { return (Defense_Base * Level / 50) + 5; }
		}
		public int SpAttack_Full {
			get { return (SpAttack_Base * Level / 50) + 5; }
		}
		public int SpDefense_Full {
			get { return (SpDefense_Base * Level / 50) + 5; }
		}
		public int Speed_Full {
			get { return (Speed_Base * Level / 50) + 5; }
		}

		public Pokémon() {
			HP_Base = 10;
			Attack_Base = 10;
			Defense_Base = 10;
			SpAttack_Base = 10;
			SpDefense_Base = 10;
			Speed_Base = 10;
		}

		public Pokémon(int hp, int att, int def, int spd_att, int spd_def, int spd) {
			HP_Base = hp;
			Attack_Base = att;
			Defense_Base = def;
			SpAttack_Base = spd_att;
			SpDefense_Base = spd_def;
			Speed_Base = spd;
		}

		public void VerhoogLevel(int aantal) {
			Level += aantal;
		}

		public void ShowStats() {
			Console.WriteLine($"{Naam} (level {Level})");
			Console.WriteLine("Full stats:");
			Console.WriteLine($"\t* Health = {HP_Full}");
			Console.WriteLine($"\t* Attack = {Attack_Full}");
			Console.WriteLine($"\t* Defense = {Defense_Full}");
			Console.WriteLine($"\t* SpAttack = {SpAttack_Full}");
			Console.WriteLine($"\t* SpDefense = {SpDefense_Full}");
			Console.WriteLine($"\t* Speed = {Speed_Full}\n");
		}
	}
}
