namespace Politiek {
	internal class VerkiezingsUitslag {
		public President VerkozenPresident { get; private set; }
		public List<Minister> VerkozenMinisters { get; private set; } = new List<Minister>();

		public VerkiezingsUitslag(President president, List<Minister> ministers) {

			VerkozenPresident = president;
			VerkozenMinisters = ministers;
		}
	}
}
