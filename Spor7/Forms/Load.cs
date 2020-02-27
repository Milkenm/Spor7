#region Usings
using System;
using System.Windows.Forms;

using ScriptsLib.Controls;
using ScriptsLib.Databases;
using ScriptsLib.Dev;
#endregion Usings



namespace Spor7.Forms
{
	public partial class Load : Form
	{
		#region Refs
		// # ================================================================================================ #
		Controls.Form _Form = new Controls.Form();
		// # ================================================================================================ #
		Scripts7 _Scripts7 = new Scripts7();
		// # ================================================================================================ #
		#endregion Refs

		#region Load
		// # ================================================================================================ #
		public Load()
		{
			try
			{
				InitializeComponent();
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void Load_Load(object sender, EventArgs e)
		{
			try
			{
				Debug._Debug = Valores._ScriptsLibDebug;
				Debug._ErrorsOnly = Valores._ScriptsLibErrorsOnly;
				AccessDatabase._DatabasePath = Valores._CaminhoBD;

				_Form.SetIntroForm(this, 0.0165, true, true, new Login(), 650);
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Load
	}
}
