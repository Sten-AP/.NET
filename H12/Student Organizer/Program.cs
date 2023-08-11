namespace Student_Organizer {
	internal class Program {
		static void Main(string[] args) {
			List<Student> students = new List<Student>();
			int keuze = 0;
			while (keuze != 3) {
				Console.Write($"1. Student gegevens invoeren.\n2. Student gegevens tonen.\n3. Stop.\nKeuze = ");
				keuze = int.Parse(Console.ReadLine());
				Console.WriteLine();

				for (int i = 0; i < 2; i++) {
					if (keuze == 1) {
						Console.Write($"{i + 1}:\nNaam = ");
						string naam = Console.ReadLine();

						Console.Write("Leeftijd = ");
						int leeftijd = int.Parse(Console.ReadLine());

						Console.Write("Klas = ");
						Klassen klas = Enum.Parse<Klassen>(Console.ReadLine());

						Console.Write("Punten communicatie = ");
						int PC = int.Parse(Console.ReadLine());

						Console.Write("Punten programming principles = ");
						int PPP = int.Parse(Console.ReadLine());

						Console.Write("Punten web tech = ");
						int PWT = int.Parse(Console.ReadLine());
						students.Add(new Student(naam, leeftijd, klas, PC, PPP, PWT));
						Console.WriteLine();
					}
					else if (keuze == 2) {
						students[i].geefOverzicht();
						Console.WriteLine();
					}
				}
			}
		}
	}
}