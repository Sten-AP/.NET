namespace Student_Organizer {
	public enum Klassen { EA1, EA2, EA3, EA4 }

	public class Student {
		public string naam { get; set; }
		public int leeftijd { get; set; }
		public Klassen klas { get; set; }
		public int puntenCommunicatie { get; set; }
		public int puntenProgrammingPrinciples { get; set; }
		public int puntenWebTech { get; set; }

		public Student(string N, int L, Klassen K, int PC, int PPP, int PWT) {
			naam = N;
			leeftijd = L;
			klas = K;
			puntenCommunicatie = PC;
			puntenProgrammingPrinciples = PPP;
			puntenWebTech = PWT;
		}

		private double berekenTotaalCijfer() {
			return (puntenCommunicatie + puntenProgrammingPrinciples + puntenWebTech) / 3;
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
}
