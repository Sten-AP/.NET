namespace Pokémon_2 {
	internal enum Types {
		normal, 
		fire, 
		water, 
		grass, 
		flying, 
		fighting, 
		poison, 
		electric, 
		ground, 
		rock, 
		psychic, 
		ice, 
		bug, 
		ghost, 
		steel, 
		dragon, 
		dark,
		fairy
	}

	internal class Pokémon {
		public Pokémon() {
			HP_Base = 10;
			Attack_Base = 10;
			Defense_Base= 10;
			SpAttack_Base= 10;
			SpDefense_Base = 10;
			Speed_Base= 10;
		}

		public Pokémon(int a, int b, int c, int d, int e, int f) {
			HP_Base = a;
			Attack_Base = b;
			Defense_Base = c;
			SpAttack_Base = d;
			SpDefense_Base = e;
			Speed_Base = f;
		}

		public int HP_Base { get; set; }
		public int Attack_Base { get; set; }
		public int Defense_Base { get; set; }
		public int SpAttack_Base { get; set; }
		public int SpDefense_Base { get; set; }
		public int Speed_Base { get; set; }

		public string Naam { get; set; }
		public Types Type { get; set; }
		public int Nummer { get; set; }

		public int Level { get; private set; } = 1;

		public double Average { 
			get { return (HP_Base + Attack_Base + Defense_Base + SpAttack_Base + SpDefense_Base + Speed_Base) / 6.0; } 
		}
		public int Total {
			get { return HP_Base + Attack_Base + Defense_Base + SpAttack_Base + SpDefense_Base + Speed_Base; }
		}
		public int HP_Full {
			get { return ((HP_Base + 50) * Level/ 50) + 10; }
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

		public void VerhoogLevel(int aantal) {
			Level += aantal;
		}

		public void ShowStats() {
			Console.WriteLine($"{Naam} (level {Level})");
			Console.WriteLine("Base stats:");
			Console.WriteLine($"\t* Health = {HP_Base}");
			Console.WriteLine($"\t* Attack = {Attack_Base}");
			Console.WriteLine($"\t* Defense = {Defense_Base}");
			Console.WriteLine($"\t* SpAttack = {SpAttack_Base}");
			Console.WriteLine($"\t* SpDefense = {SpDefense_Base}");
			Console.WriteLine($"\t* Speed = {Speed_Base}");
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
