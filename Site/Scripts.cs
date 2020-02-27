#region Usings
using System;
using ScriptsLib.AspNet;
using ScriptsLib.Controls;
using ScriptsLib.Databases;
using ScriptsLib.Tools;
#endregion Usings



namespace Site
{
	public class Scripts
	{
		public AccessDatabase _Database = new AccessDatabase();
		public Tools _Tools = new Tools();
		public Tools.DatabaseTools _DatabaseTools = new Tools.DatabaseTools();
		public AspNet _AspNet = new AspNet();
		public Controls.TextBox _Controls_TextBox = new Controls.TextBox();

		private bool _Exceptions = false;
		public void Exception(Exception _Exception)
		{
			if (_Exceptions == true)
			{
				_Tools.Exception(_Exception);
			}
		}
	}
}