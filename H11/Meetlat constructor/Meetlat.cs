namespace Meetlat_constructor {
	internal class Meetlat {
		public Meetlat(double LengteInMeter) {
			lengte = LengteInMeter;
		}

		private double lengte;

		public double LengteInM { get { return lengte; } }

		public double LengteInCm { get { return lengte * 100; } }

		public double LengteInKm { get { return lengte / 1000; } }

		public double LengteInVoet { get { return lengte * 3.2808; } }

	}
}
