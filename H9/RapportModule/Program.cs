Rapport mijnpunten = new Rapport();
mijnpunten.percentage = 85;
mijnpunten.printGraad();

class Rapport {
	public int percentage;

	public void printGraad() {
		if (percentage < 50) Console.WriteLine("Niet geslaagd");
		if (percentage > 50 && percentage <= 68) Console.WriteLine("Voldoende");
		if (percentage > 68 && percentage <= 75) Console.WriteLine("Onderscheiding");
		if (percentage > 75 && percentage <= 85) Console.WriteLine("Grote onderscheiding");
		if (percentage > 85) Console.WriteLine("Grootste onderscheiding");
	}
}
