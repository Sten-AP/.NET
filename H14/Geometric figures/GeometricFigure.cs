namespace Geometric_figures {
	abstract class GeometricFigure {
		public int Hoogte;
		public int Breedte;
		public double Oppervlakte {
			get { return BerekenOppervlakte(); }
		}
		public abstract double BerekenOppervlakte();
	}
}
