namespace Geometric_figures {
	internal class Vierkant: Rechthoek {
		public Vierkant(int hoogte, int breedte) {
			if (hoogte != breedte) {
				base.Hoogte = hoogte;
				base.Breedte = hoogte;
			}
			else {
				base.Hoogte = hoogte;
				base.Breedte = breedte;
			}
		}
		public Vierkant(int lengte) {
			base.Hoogte = lengte;
			base.Breedte = lengte;
		}
	}
}
