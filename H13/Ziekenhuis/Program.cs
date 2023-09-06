namespace Ziekenhuis {
	internal class Program {
		static void Main(string[] args) {
			Patient patient = new Patient("pers1", 7);
			patient.ToonInfo();
			VerzekerdePatient verzekerdePatient = new VerzekerdePatient("pers2", 7);
			verzekerdePatient.ToonInfo();
		}
	}
}