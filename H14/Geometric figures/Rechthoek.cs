namespace Geometric_figures {
	internal class Rechthoek: GeometricFigure {
		public override double BerekenOppervlakte() {
			return base.Hoogte * base.Breedte;
		}
	}
}
