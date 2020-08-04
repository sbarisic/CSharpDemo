using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Threading;
using ZweiteShared;

namespace ASPNET_WS_Demo {
	public class AspNetWS : IAspNetWS {
		public Klijent FindClient(string InterniBroj) {
			Thread.Sleep(1000);

			if (InterniBroj == "000420666")
				return new Klijent(0, "Qwerty", "McQuertyFace", InterniBroj);

			return null;
		}
	}
}
