using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ASPNET_WS_Demo {
	public class AspNetWS : IAspNetWS {
		public int CrappySum(int A, int B) {
			return A + B;
		}
	}
}
