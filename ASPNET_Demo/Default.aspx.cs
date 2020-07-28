using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPNET_Demo.code;

namespace ASPNET_Demo {
	[LinkedPage(10, Link = "Default.aspx", Title = "Default")]
	public partial class _Default : Page {
		protected void Page_Load(object sender, EventArgs e) {
			AspNetWS.AspNetWSClient AspNetWS = new AspNetWS.AspNetWSClient();
			AspNetWS.CrappySum(2, 3);

		}
	}
}