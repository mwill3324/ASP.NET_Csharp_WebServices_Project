﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment_5_Final.MarcusReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MarcusReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getCloseStores", ReplyAction="http://tempuri.org/IService/getCloseStoresResponse")]
        string[] getCloseStores(string zipcode, string keyword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getCloseStores", ReplyAction="http://tempuri.org/IService/getCloseStoresResponse")]
        System.Threading.Tasks.Task<string[]> getCloseStoresAsync(string zipcode, string keyword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getCoordinates", ReplyAction="http://tempuri.org/IService/getCoordinatesResponse")]
        string getCoordinates(string zipcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getCoordinates", ReplyAction="http://tempuri.org/IService/getCoordinatesResponse")]
        System.Threading.Tasks.Task<string> getCoordinatesAsync(string zipcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getBalance", ReplyAction="http://tempuri.org/IService/getBalanceResponse")]
        string getBalance(string Account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getBalance", ReplyAction="http://tempuri.org/IService/getBalanceResponse")]
        System.Threading.Tasks.Task<string> getBalanceAsync(string Account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/deposite", ReplyAction="http://tempuri.org/IService/depositeResponse")]
        string deposite(string Account, string amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/deposite", ReplyAction="http://tempuri.org/IService/depositeResponse")]
        System.Threading.Tasks.Task<string> depositeAsync(string Account, string amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getCrime", ReplyAction="http://tempuri.org/IService/getCrimeResponse")]
        string[] getCrime(string lat, string lon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getCrime", ReplyAction="http://tempuri.org/IService/getCrimeResponse")]
        System.Threading.Tasks.Task<string[]> getCrimeAsync(string lat, string lon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getState", ReplyAction="http://tempuri.org/IService/getStateResponse")]
        string getState(string lat, string lon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getState", ReplyAction="http://tempuri.org/IService/getStateResponse")]
        System.Threading.Tasks.Task<string> getStateAsync(string lat, string lon);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Assignment_5_Final.MarcusReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Assignment_5_Final.MarcusReference1.IService>, Assignment_5_Final.MarcusReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] getCloseStores(string zipcode, string keyword) {
            return base.Channel.getCloseStores(zipcode, keyword);
        }
        
        public System.Threading.Tasks.Task<string[]> getCloseStoresAsync(string zipcode, string keyword) {
            return base.Channel.getCloseStoresAsync(zipcode, keyword);
        }
        
        public string getCoordinates(string zipcode) {
            return base.Channel.getCoordinates(zipcode);
        }
        
        public System.Threading.Tasks.Task<string> getCoordinatesAsync(string zipcode) {
            return base.Channel.getCoordinatesAsync(zipcode);
        }
        
        public string getBalance(string Account) {
            return base.Channel.getBalance(Account);
        }
        
        public System.Threading.Tasks.Task<string> getBalanceAsync(string Account) {
            return base.Channel.getBalanceAsync(Account);
        }
        
        public string deposite(string Account, string amount) {
            return base.Channel.deposite(Account, amount);
        }
        
        public System.Threading.Tasks.Task<string> depositeAsync(string Account, string amount) {
            return base.Channel.depositeAsync(Account, amount);
        }
        
        public string[] getCrime(string lat, string lon) {
            return base.Channel.getCrime(lat, lon);
        }
        
        public System.Threading.Tasks.Task<string[]> getCrimeAsync(string lat, string lon) {
            return base.Channel.getCrimeAsync(lat, lon);
        }
        
        public string getState(string lat, string lon) {
            return base.Channel.getState(lat, lon);
        }
        
        public System.Threading.Tasks.Task<string> getStateAsync(string lat, string lon) {
            return base.Channel.getStateAsync(lat, lon);
        }
    }
}
