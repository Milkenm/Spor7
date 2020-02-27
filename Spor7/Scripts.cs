#region Usings
using System;
using System.Collections.Generic;
using ScriptsLib.Tools;
#endregion Usings



namespace Spor7
{
	public class Scripts7
	{
		#region Refs
		Tools _Tools = new Tools();
		#endregion Refs












		#region Valor Zero
		public int? ValorZero(List<string> _Consulta)
		{
			int? _Valor = null;

			if (_Consulta.Count > 0)
			{
				if (!String.IsNullOrEmpty(_Consulta[0]))
				{
					_Valor = Convert.ToInt32(_Consulta[0]);
				}
			}

			return _Valor;
		}
		#endregion Valor Zero



		#region Exception
		public void Exception(Exception _Exception)
		{
			if (Valores._Debug == true)
			{
				_Tools.Exception(_Exception);
			}
		}
		#endregion Exception
	}
}
