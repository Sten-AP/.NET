namespace Bookmark_Manager {
	internal class Program {
		static void Main(string[] args) {
			BookMark u = new BookMark();
			u.Naam = "Google";
			u.URL = "https://learning.ap.be/course/view.php?id=53526";
			u.ToonSite();
		}
	}
}