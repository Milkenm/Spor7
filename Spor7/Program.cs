#region Usings
using System;
using System.Diagnostics;
using System.Windows.Forms;
using ScriptsLib.Tools;
#endregion Usings



namespace Spor7
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			if (new Tools().IsApplicationRunning() == false)
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Forms.Load());
			}
		}
	}
}
