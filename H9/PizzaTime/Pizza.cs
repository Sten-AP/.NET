public class Pizza {
	private string toppings = "peperoni";
	private int diameter = 30;
	private double price = 10.0;

	public string Toppings {
		get { return toppings; }
		set { if (value != "") toppings = value; }
	}

	public int Diameter {
		get { return diameter; }
		set { if (value > 0) diameter = value; }
	}

	public double Price {
		get { return price; }
		set { if (value > 0) price = value; }
	}

	public void printPizza() {
		Console.WriteLine($"Toppings:\t{this.toppings}\nDiameter:\t{this.diameter} cm\nPrice:\t\t{this.price} euro\n");
	}
}

