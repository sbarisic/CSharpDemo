using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZweiteShared;

namespace ASPNET_Demo.code {
	public class ZweitePage : Page {
		public Klijent Klijent {
			get {
				return Session[nameof(Klijent)] as Klijent;
			}

			set {
				Session[nameof(Klijent)] = value;
			}
		}


		[WebMethod]
		public static void ClearClient() {
			ZweitePage CurPage = HttpContext.Current.Handler as ZweitePage;

			if (CurPage != null)
				CurPage.Klijent = null;
		}

		[WebMethod]
		public static string[] FindClient(string InterniBroj) {
			FindClient(InterniBroj, out Klijent K);

			if (K == null)
				return null;

			return new[] { K.Ime, K.Prezime, K.InterniBroj };
		}

		public static void FindClient(string InterniBroj, out Klijent K) {
			using (AspNetWS.AspNetWSClient WS = new AspNetWS.AspNetWSClient()) {
				K = WS.FindClient(InterniBroj);
			}
		}
	}
}