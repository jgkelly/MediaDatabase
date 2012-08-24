using System.ServiceProcess;
using Service;

namespace MediaDatabase.Service
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			ServiceBase[] ServicesToRun;
			ServicesToRun = new ServiceBase[] 
			{ 
				new MediaDatabaseService() 
			};
			ServiceBase.Run(ServicesToRun);
		}
	}
}
