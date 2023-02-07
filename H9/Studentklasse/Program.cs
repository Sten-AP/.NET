Student student1 = new Student();
student1.klas = Klassen.TI1;
student1.leeftijd = 21;
student1.naam = "Joske Vermeulen";
student1.puntenCommunicatie = 12;
student1.puntenProgrammingPrinciples = 15;
student1.puntenWebTech = 13;

student1.geefOverzicht();

enum Klassen {
	TI1,
	TI2,
	TI3,
	TI4,
	TI5,
	TI6,
	TI7,
	TI8,
}


class Student {
	public string naam;
	public int leeftijd;
	public Klassen klas;
	public int puntenCommunicatie;
	public int puntenProgrammingPrinciples;
	public int puntenWebTech;

	private double berekenTotaalCijfer() {
		return ((double)puntenCommunicatie + (double)puntenProgrammingPrinciples + (double)puntenWebTech) / 3;
	}

	public void geefOverzicht() {
		Console.WriteLine($"{naam}, {leeftijd} jaar");
		Console.WriteLine($"Klas: {klas}\n");
		Console.WriteLine("Cijferrapport:");
		Console.WriteLine("**********");
		Console.WriteLine($"Communicatie:\t\t {puntenCommunicatie}");
		Console.WriteLine($"Programming Principles:\t {puntenProgrammingPrinciples}");
		Console.WriteLine($"Web Technology:\t\t {puntenWebTech}");
		Console.WriteLine($"Gemiddelde:\t\t {berekenTotaalCijfer():0.0}");
	}
}