namespace Moederbord {
	public class Moederbord: Merk {
		public CPU CPU { get; set; } = null;
		public GPU GPU { get; set; } = null;
		private List<RAM> ram;
		public List<RAM> RAM {
			get { return ram; }
			set {
				if (value.Count > AantalRAMSlots) Console.WriteLine("Te veel RAM.");
				else ram = value;
			}
		}
		public int AantalRAMSlots;

		public Moederbord(string naam, int aantalRAMSlots) : base(naam) {
			AantalRAMSlots = aantalRAMSlots;
		}

		public void TestMoederbord() {
			if (CPU != null && GPU != null && RAM != null) {
				Console.WriteLine("Moederbord is in orde.");
			}
			else {
				if (CPU == null) {
					Console.WriteLine("De CPU mist nog.");
				}
				if (GPU == null) {
					Console.WriteLine("De GPU mist nog.");
				}
				if (RAM == null) {
					Console.WriteLine("Het RAM mist nog.");
				}
			}
		}
	}
}
