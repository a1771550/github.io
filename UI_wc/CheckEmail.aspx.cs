using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using UI.WebServices;

namespace UI
{
	public partial class Email : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnCheck_OnClick(object sender, EventArgs e)
		{
			var repo = new AspNetUserRepository();
			if (repo.CheckIfDuplicatedEmail("a1771550@gmail.com"))
			{
				Output.Text = "Duplicated Email";
			}

		}
	}
}