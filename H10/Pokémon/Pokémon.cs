namespace Pokémon {
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
		public int HP_Base;
		public int Attack_Base;
		public int Defense_Base;
		public int SpAttack_Base;
		public int SpDefense_Base;
		public int Speed_Base;

		public string Naam { get; set; }
		public Types Type { get; set; }
		public int Nummer { get; set; }

		public int Level { get; private set; }

		public double Average { 
			get { return (HP_Base + Attack_Base + Defense_Base + SpAttack_Base + SpDefense_Base + Speed_Base) / 6.0; } 
		}
		public int Total {
			get { return HP_Base + Attack_Base + Defense_Base + SpAttack_Base + SpDefense_Base + Speed_Base; }
		}
		public int HP_Full {
			get { return (((HP_Base + 50) * Level) / 50) + 10; }
		}
		public int Attack_Full {
			get { return ((Attack_Base * Level) / 50) + 5; }
		}
		public int Defense_Full {
			get { return ((Defense_Base * Level) / 50) + 5; }
		}
		public int SpAttack_Full {
			get { return ((SpAttack_Base * Level) / 50) + 5; }
		}
		public int SpDefense_Full {
			get { return ((SpDefense_Base * Level) / 50) + 5; }
		}
		public int Speed_Full {
			get { return ((Speed_Base * Level) / 50) + 5; }
		}
		public void VerhoogLevel() {
			Level++;
		}
	}
}
