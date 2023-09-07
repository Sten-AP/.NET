namespace Moederbord {
	internal class Program {
		static void Main(string[] args) {
			Moederbord moederbord = new Moederbord("MSI Z790-A PRO", 4);
			CPU cpu = new CPU("I9 14900K", 6.1, 24);
			GPU gpu = new GPU("RTX 4090", 2780, 20);
			List<RAM> ram = new List<RAM>(4);

			for (byte i = 0; i < 4; i++) {
				ram.Add(new RAM("DDR5 HyperX", 6000, 16));
			}

			moederbord.CPU = cpu;
			moederbord.GPU = gpu;
			moederbord.RAM = ram;
			moederbord.TestMoederbord();
		}
	}
}