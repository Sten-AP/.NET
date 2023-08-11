using System.Net;
using System.Text.RegularExpressions;

namespace Bookmark_Manager {
	public class BookMark {

		public string Naam { get; set; }
		public string URL { get; set; }
		public void ToonSite() {
			WebClient wc = new WebClient();
			string result = wc.DownloadString(URL);
			Console.WriteLine(GetPlainTextFromHtml(result));
		}
		//Bron: https://www.mercator.eu/mercator/std/info_aruba/reporting-hoe-gegevens-afdrukken-met-html-tags.html
		private string GetPlainTextFromHtml(string htmlString) {
			string htmlTagPattern = "<.*?>";
			var regexCss = new Regex("(\\<script(.+?)\\</script\\>)|(\\<style(.+?)\\</style\\>)", RegexOptions.Singleline | RegexOptions.IgnoreCase);
			htmlString = regexCss.Replace(htmlString, string.Empty);
			htmlString = Regex.Replace(htmlString, htmlTagPattern, string.Empty);
			htmlString = Regex.Replace(htmlString, @"^\s+$[\r\n]*", "", RegexOptions.Multiline);
			htmlString = htmlString.Replace("&nbsp;", " ");
			return htmlString;
		}
	}
}
