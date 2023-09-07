namespace Politiek {
	public class VerkiezingsUitslag {
		static Random rng = new Random();

		private President verkozenPresident = null;
		public President VerkozenPresident {
			get { return verkozenPresident; }
			set { verkozenPresident = value; }
		}

		private List<Minister> verkozenMinisters;
		public List<Minister> VerkozenMinisters {
			get { return verkozenMinisters; }
			set { verkozenMinisters = value; }
		}

		public VerkiezingsUitslag() {
			VerkozenPresident = new President() { Naam = NaamGen() };
			VerkozenMinisters = new List<Minister>();

			for (int i = 0; i < 5; i++) {
				VerkozenMinisters.Add(new Minister() { Naam = NaamGen() });
			}
		}

		private string NaamGen() {
			string naam = "";
			for (int i = 0; i < rng.Next(5, 10); i++) {
				naam += (char)rng.Next('a', 'z');
			}
			return naam;
		}
	}
}
