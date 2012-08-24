using System.Diagnostics;
using System.ServiceProcess;

namespace Service
{
	public partial class MediaDatabaseService : ServiceBase
	{
		private const string SourceName = "MediaDatabaseSource";
		private const string LogName = "MediaDatabaseLog";

		private EventLog Logger
		{
			get
			{
				return _eventLog;
			}
		}

		public MediaDatabaseService()
		{
			InitializeComponent();
			if (!EventLog.SourceExists(SourceName))
			{
				EventLog.CreateEventSource(SourceName, LogName);
			}

			Logger.Source = SourceName;
			Logger.Log = LogName;
		}

		protected override void OnStart(string[] args)
		{
			Logger.WriteEntry("OnStart()");
		}

		protected override void OnStop()
		{
			Logger.WriteEntry("OnStop()");
		}
	}
}
