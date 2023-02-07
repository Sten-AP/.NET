Nummers paar1 = new Nummers();
paar1.getal1 = 12;
paar1.getal2 = 34;
Console.WriteLine($"Paar: {paar1.Getal1}, {paar1.Getal2}");

int berekendeSom = paar1.som();
Console.WriteLine($"Som =  {berekendeSom}");

Console.WriteLine($"Verschil = {paar1.verschil()}");
Console.WriteLine($"Product = {paar1.product()}");
Console.WriteLine($"Quotient = {paar1.quotient()}");

class Nummers {
	public int getal1;
	public int getal2;

	public int som() {
		return getal1 + getal2;
	}

	public int verschil() {
		return getal1 - getal2;
	}

	public int product() {
		return getal1 * getal2;
	}

	public double quotient() {
		if (getal2 == 0) {
			Console.WriteLine("Kan niet delen door 0.");
			return 0.0;
		}
		return (double)getal1 / (double)getal2;
	}
}