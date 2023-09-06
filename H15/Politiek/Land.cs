namespace Politiek {
	internal class Land {
		private President President;
		private Minister EersteMinister;
		private List<Minister> Ministers = new List<Minister>(4);

		public void MaakRegering(President president, List<Minister> ministers) {
			if (President == null) {
				President = president;
				EersteMinister = ministers[0];
				if (ministers.Count >= 2) {
					for (byte i = 1; i < ministers.Count; i++) Ministers.Add(ministers[i]);
				}
			}
			else Console.WriteLine("Regering bestaat al");
		}

		public void JaarVerder() {
			if (President != null) {
				President.JaarVerder();
				if (President.Teller <= 0) {
					Console.WriteLine("Regering is gedaan");
					President = null;
					EersteMinister = null;
					Ministers.Clear();
				}
			}
		}

	}
}
