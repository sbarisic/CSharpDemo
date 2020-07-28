using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ASPNET_WS_Demo {
	[ServiceContract]
	public interface IAspNetWS {
		[OperationContract]
		int CrappySum(int A, int B);
	}
}
