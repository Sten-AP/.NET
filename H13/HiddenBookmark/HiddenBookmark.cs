namespace HiddenBookmark {
	internal class HiddenBookmark : BookMark {

		public override void ToonSite() {
			Console.WriteLine("**********INCOGNITO MODE************");
			base.ToonSite();
			Console.WriteLine("**********INCOGNITO MODE************");
		}
	}
}
