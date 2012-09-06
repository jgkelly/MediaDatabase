using System.Collections.Generic;

namespace MediaDatabase.Scanner
{
	public interface IScanner
	{
		string Name { get; }
		List<ISource> Sources { get; }

		void Scan();
	}
}
