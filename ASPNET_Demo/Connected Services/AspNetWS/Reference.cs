﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASPNET_Demo.AspNetWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AspNetWS.IAspNetWS")]
    public interface IAspNetWS {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAspNetWS/FindClient", ReplyAction="http://tempuri.org/IAspNetWS/FindClientResponse")]
        ZweiteShared.Klijent FindClient(string InterniBroj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAspNetWS/FindClient", ReplyAction="http://tempuri.org/IAspNetWS/FindClientResponse")]
        System.Threading.Tasks.Task<ZweiteShared.Klijent> FindClientAsync(string InterniBroj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAspNetWS/GetCustomConfig", ReplyAction="http://tempuri.org/IAspNetWS/GetCustomConfigResponse")]
        ZweiteShared.CustomConfig GetCustomConfig();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAspNetWS/GetCustomConfig", ReplyAction="http://tempuri.org/IAspNetWS/GetCustomConfigResponse")]
        System.Threading.Tasks.Task<ZweiteShared.CustomConfig> GetCustomConfigAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAspNetWSChannel : ASPNET_Demo.AspNetWS.IAspNetWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AspNetWSClient : System.ServiceModel.ClientBase<ASPNET_Demo.AspNetWS.IAspNetWS>, ASPNET_Demo.AspNetWS.IAspNetWS {
        
        public AspNetWSClient() {
        }
        
        public AspNetWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AspNetWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AspNetWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AspNetWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ZweiteShared.Klijent FindClient(string InterniBroj) {
            return base.Channel.FindClient(InterniBroj);
        }
        
        public System.Threading.Tasks.Task<ZweiteShared.Klijent> FindClientAsync(string InterniBroj) {
            return base.Channel.FindClientAsync(InterniBroj);
        }
        
        public ZweiteShared.CustomConfig GetCustomConfig() {
            return base.Channel.GetCustomConfig();
        }
        
        public System.Threading.Tasks.Task<ZweiteShared.CustomConfig> GetCustomConfigAsync() {
            return base.Channel.GetCustomConfigAsync();
        }
    }
}
