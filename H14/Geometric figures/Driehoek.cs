namespace Geometric_figures {
	internal class Driehoek: GeometricFigure {
		public override double BerekenOppervlakte() {
			return base.Breedte * base.Hoogte / 2;
		}
	}
}
