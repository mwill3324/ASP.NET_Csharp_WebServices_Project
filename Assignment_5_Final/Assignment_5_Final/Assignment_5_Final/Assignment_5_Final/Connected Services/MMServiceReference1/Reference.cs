﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment_5_Final.MMServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MMServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/foodPlace", ReplyAction="http://tempuri.org/IService1/foodPlaceResponse")]
        string[] foodPlace(string zipcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/foodPlace", ReplyAction="http://tempuri.org/IService1/foodPlaceResponse")]
        System.Threading.Tasks.Task<string[]> foodPlaceAsync(string zipcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Number2Word", ReplyAction="http://tempuri.org/IService1/Number2WordResponse")]
        string Number2Word(string number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Number2Word", ReplyAction="http://tempuri.org/IService1/Number2WordResponse")]
        System.Threading.Tasks.Task<string> Number2WordAsync(string number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/signUP", ReplyAction="http://tempuri.org/IService1/signUPResponse")]
        string[] signUP(string email, string password, string fName, string lName, int age, string accouType, string status, bool directDepo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/signUP", ReplyAction="http://tempuri.org/IService1/signUPResponse")]
        System.Threading.Tasks.Task<string[]> signUPAsync(string email, string password, string fName, string lName, int age, string accouType, string status, bool directDepo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/logIn", ReplyAction="http://tempuri.org/IService1/logInResponse")]
        string logIn(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/logIn", ReplyAction="http://tempuri.org/IService1/logInResponse")]
        System.Threading.Tasks.Task<string> logInAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/buySoda", ReplyAction="http://tempuri.org/IService1/buySodaResponse")]
        string buySoda(int count, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/buySoda", ReplyAction="http://tempuri.org/IService1/buySodaResponse")]
        System.Threading.Tasks.Task<string> buySodaAsync(int count, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/write2XML", ReplyAction="http://tempuri.org/IService1/write2XMLResponse")]
        bool write2XML(string fileName, string add);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/write2XML", ReplyAction="http://tempuri.org/IService1/write2XMLResponse")]
        System.Threading.Tasks.Task<bool> write2XMLAsync(string fileName, string add);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/searchXML", ReplyAction="http://tempuri.org/IService1/searchXMLResponse")]
        string searchXML(string fileName, string searchItem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/searchXML", ReplyAction="http://tempuri.org/IService1/searchXMLResponse")]
        System.Threading.Tasks.Task<string> searchXMLAsync(string fileName, string searchItem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Decryption", ReplyAction="http://tempuri.org/IService1/DecryptionResponse")]
        string Decryption(string encryptedString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Decryption", ReplyAction="http://tempuri.org/IService1/DecryptionResponse")]
        System.Threading.Tasks.Task<string> DecryptionAsync(string encryptedString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Encryption", ReplyAction="http://tempuri.org/IService1/EncryptionResponse")]
        string Encryption(string plainString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Encryption", ReplyAction="http://tempuri.org/IService1/EncryptionResponse")]
        System.Threading.Tasks.Task<string> EncryptionAsync(string plainString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteUser", ReplyAction="http://tempuri.org/IService1/deleteUserResponse")]
        bool deleteUser(string fileName, string deleteString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteUser", ReplyAction="http://tempuri.org/IService1/deleteUserResponse")]
        System.Threading.Tasks.Task<bool> deleteUserAsync(string fileName, string deleteString);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Assignment_5_Final.MMServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Assignment_5_Final.MMServiceReference1.IService1>, Assignment_5_Final.MMServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] foodPlace(string zipcode) {
            return base.Channel.foodPlace(zipcode);
        }
        
        public System.Threading.Tasks.Task<string[]> foodPlaceAsync(string zipcode) {
            return base.Channel.foodPlaceAsync(zipcode);
        }
        
        public string Number2Word(string number) {
            return base.Channel.Number2Word(number);
        }
        
        public System.Threading.Tasks.Task<string> Number2WordAsync(string number) {
            return base.Channel.Number2WordAsync(number);
        }
        
        public string[] signUP(string email, string password, string fName, string lName, int age, string accouType, string status, bool directDepo) {
            return base.Channel.signUP(email, password, fName, lName, age, accouType, status, directDepo);
        }
        
        public System.Threading.Tasks.Task<string[]> signUPAsync(string email, string password, string fName, string lName, int age, string accouType, string status, bool directDepo) {
            return base.Channel.signUPAsync(email, password, fName, lName, age, accouType, status, directDepo);
        }
        
        public string logIn(string email, string password) {
            return base.Channel.logIn(email, password);
        }
        
        public System.Threading.Tasks.Task<string> logInAsync(string email, string password) {
            return base.Channel.logInAsync(email, password);
        }
        
        public string buySoda(int count, string email, string password) {
            return base.Channel.buySoda(count, email, password);
        }
        
        public System.Threading.Tasks.Task<string> buySodaAsync(int count, string email, string password) {
            return base.Channel.buySodaAsync(count, email, password);
        }
        
        public bool write2XML(string fileName, string add) {
            return base.Channel.write2XML(fileName, add);
        }
        
        public System.Threading.Tasks.Task<bool> write2XMLAsync(string fileName, string add) {
            return base.Channel.write2XMLAsync(fileName, add);
        }
        
        public string searchXML(string fileName, string searchItem) {
            return base.Channel.searchXML(fileName, searchItem);
        }
        
        public System.Threading.Tasks.Task<string> searchXMLAsync(string fileName, string searchItem) {
            return base.Channel.searchXMLAsync(fileName, searchItem);
        }
        
        public string Decryption(string encryptedString) {
            return base.Channel.Decryption(encryptedString);
        }
        
        public System.Threading.Tasks.Task<string> DecryptionAsync(string encryptedString) {
            return base.Channel.DecryptionAsync(encryptedString);
        }
        
        public string Encryption(string plainString) {
            return base.Channel.Encryption(plainString);
        }
        
        public System.Threading.Tasks.Task<string> EncryptionAsync(string plainString) {
            return base.Channel.EncryptionAsync(plainString);
        }
        
        public bool deleteUser(string fileName, string deleteString) {
            return base.Channel.deleteUser(fileName, deleteString);
        }
        
        public System.Threading.Tasks.Task<bool> deleteUserAsync(string fileName, string deleteString) {
            return base.Channel.deleteUserAsync(fileName, deleteString);
        }
    }
}
