using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ZweiteShared;

namespace ASPNET_WS_Demo {
	[ServiceContract]
	public interface IAspNetWS {
		[OperationContract]
		Klijent FindClient(string InterniBroj);
	}
}
