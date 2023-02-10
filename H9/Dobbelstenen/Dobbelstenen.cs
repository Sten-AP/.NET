namespace Dobbelstenen {
	public class Dobbelstenen {
		public void WerpEnTel6() {
			Random randomGetal = new Random();
			int aantal6 = 0;
			for (int i = 0; i < 1000; i++) {
				if (randomGetal.Next(1, 7) == 6 && randomGetal.Next(1, 7) == 6) aantal6++;
			}
			Console.WriteLine($"Aantal keer dat beide dobbelstenen 6 waren: {aantal6}");
		}
	}
}
