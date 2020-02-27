#region Usings
using System;
using System.Windows.Forms;
#endregion Usings



namespace Spor7.Scripts
{
	public partial class Error
	{
		public static void Show(Exception _Exception)
		{
#if DEBUG
			MessageBox.Show(_Exception.Message, _Exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
		}
	}
}