using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site
{
	public partial class sair : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				Session["ID"] = null;
				Response.Redirect("/index.aspx");
			}
			catch (Exception _Exception)
			{
				new Scripts().Exception(_Exception);
			}
		}
	}
}