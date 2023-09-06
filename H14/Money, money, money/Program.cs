namespace Money__money__money {
	internal class Program {
		static void Main(string[] args) {
			BankRekening rekening1 = new BankRekening();
			rekening1.VoegGeldToe(110);
			rekening1.HaalGeldAf(10);
			Console.WriteLine(rekening1.rekening);
			Console.WriteLine(rekening1.BerekenRente());
			Console.WriteLine();

			SpaarRekening rekening2 = new SpaarRekening();
			rekening2.VoegGeldToe(1000);
			Console.WriteLine(rekening2.rekening);
			Console.WriteLine(rekening2.BerekenRente());
			Console.WriteLine();

			ProRekening rekening3 = new ProRekening();
			rekening3.VoegGeldToe(7684);
			Console.WriteLine(rekening3.rekening);
			Console.WriteLine(rekening3.BerekenRente());
		}
	}
}