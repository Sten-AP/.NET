namespace Prijzen_met_foreach
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double[] prijzen = new double[5];
			double som = 0;

			for (int i = 0; i < prijzen.Length; i++) { 
				Console.Write($"{i+1}:\t");
				prijzen[i] = double.Parse(Console.ReadLine());
				som += prijzen[i];
			}

			Console.WriteLine("Prijzen groter of gelijk aan 5:");

			foreach (double prijs in prijzen)
			{
				if (prijs > 5) { Console.WriteLine(prijs); }
			}

			Console.WriteLine($"Gemiddelde: {som/prijzen.Length}");
		}
	}
}