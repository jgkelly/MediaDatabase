using System.Collections.Generic;
using MediaDatabase.Scanner;

namespace Music.Scanner
{
	public class MusicScanner : IScanner
	{
		private List<string> SourceFolders;

		#region IScanner Members

		public string Name
		{
			get { throw new System.NotImplementedException(); }
		}

		public System.Collections.Generic.List<MediaDatabase.Scanner.ISource> Sources
		{
			get { throw new System.NotImplementedException(); }
		}

		public void Scan()
		{
			throw new System.NotImplementedException();
		}

		#endregion
	}
}
