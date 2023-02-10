using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meetlat {
	internal class Meetlat {
		private double lengte;
		public double BeginLengte { 
			set { lengte = value; } 
		}

		public double LengteInM {
			get { return lengte; }
		}
		public double LengteInCm {
			get { return lengte * 100; }
		}
		public double LengteInKm {
			get { return lengte / 1000; }
		}
		public double LengteInVoet {
			get { return lengte * 3.2808; }
		}
	}
}
