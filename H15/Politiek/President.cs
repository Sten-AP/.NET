namespace Politiek {
	public class President: Minister {
		public int Teller { get; private set; } = 4;

		public void JaarVerder() {
			Teller--;
		}
	}
}
