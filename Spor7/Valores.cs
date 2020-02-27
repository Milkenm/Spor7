using System.Windows.Forms;

namespace Spor7
{
	public class Valores
	{
		public static Valores _Valores = new Valores();

		public static readonly bool _Debug = false;
		public static readonly bool _ScriptsLibDebug = false;
		public static readonly bool _ScriptsLibErrorsOnly = false;



		#region Caminhos
		public static readonly string _CaminhoBD = @"C:\Milkenm\Projects\Visual Studio\Spor7\_Dados\BD_Spor7.mdb";

		public static readonly string _CaminhoImagensFuncionarios = @"C:\Milkenm\Projects\Visual Studio\Spor7\_Dados\Imagens\Imagens_Funcionarios\";
		public static readonly string _CaminhoImagensProdutos = @"C:\Milkenm\Projects\Visual Studio\Spor7\Site\_imagens\Imagens_Produtos\";
		public static readonly string _CaminhoImagensUtilizadores = @"C:\Milkenm\Projects\Visual Studio\Spor7\_Dados\Imagens\Imagens_Utilizadores\";
		#endregion Caminhos





		#region System
		public static Forms.Main _Main;

		public void LoadMain(int? _IdUtilizador)
		{
			_Main = new Forms.Main(_IdUtilizador);
		}
		#endregion System
	}
}
