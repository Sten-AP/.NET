namespace Pokédex {
	public class Pokédex {
		private List<Pokémon> pokemons = new List<Pokémon>();
		private Random r = new Random();

		public void toevoegen(Pokémon pokemon) {
			pokemons.Add(pokemon);
		}

		public void toon_pokedex() {
			foreach (Pokémon pokemon in pokemons) {
				pokemon.ShowInfo();
			}
		}

		public void verwijder_random() {
			pokemons.RemoveAt(r.Next(0, pokemons.Count));
		}

		public void verwijder_alles() {
			pokemons.RemoveRange(0, pokemons.Count);
		}
	}
}
