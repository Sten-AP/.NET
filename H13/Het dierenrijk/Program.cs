namespace Het_dierenrijk {
	internal class Program {
		static void Main(string[] args) {
			List<Animal> animals = new List<Animal>();
			animals.Add(new Rabbit("zwart", true, 20));
			animals.Add(new Cow(10, false, 150));
			animals.Add(new Dog("Duitse herder", true, 40));
			animals.Add(new Snake("Geruit", 300, 8));
			animals.Add(new Iguana("groen", 200, 30));

			foreach (Animal animal in animals) {
				animal.ToonInfo();
				Console.WriteLine();
			}

		}
	}
}