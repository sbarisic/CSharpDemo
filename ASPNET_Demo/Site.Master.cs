using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;
using ASPNET_Demo.code;
using System.Threading.Tasks;
using System.Threading;
using System.Web.Services;
using ZweiteShared;

namespace ASPNET_Demo {
	public partial class SiteMaster : MasterPage {
		protected void Page_Load(object sender, EventArgs e) {
			Assembly Cur = Assembly.GetExecutingAssembly();
			IEnumerable<Type> LinkedPages = Cur.GetTypes()
				.Where(T => T.GetCustomAttribute<LinkedPageAttribute>() != null)
				.OrderBy(T => T.GetCustomAttribute<LinkedPageAttribute>().Index);

			foreach (Type T in LinkedPages) {
				LinkedPageAttribute Attrib = T.GetCustomAttribute<LinkedPageAttribute>();
				HyperLink PageLink = new HyperLink();

				if (Attrib.Title == null)
					PageLink.Text = T.Name;
				else
					PageLink.Text = Attrib.Title;

				if (Attrib.Link == null)
					PageLink.NavigateUrl = T.Name + ".aspx";
				else
					PageLink.NavigateUrl = Attrib.Link;

				divSidenav.Controls.Add(PageLink);
			}

			FillSelectedClient(Session[nameof(Klijent)] as Klijent);
		}

		void FillSelectedClient(Klijent K) {
			if (K != null) {
				divClientSelection.Visible = true;
				lblIme.Text = K.Ime;
				lblPrezime.Text = K.Prezime;
				lblInterniBroj.Text = K.InterniBroj;
			} else {
				divClientSelection.Visible = false;
			}
		}

		protected void btnSelectClient_Click(object sender, EventArgs e) {
			ZweitePage.FindClient(ibroj.Value, out Klijent K);
			Session[nameof(Klijent)] = K;
			FillSelectedClient(K);
		}
	}
}