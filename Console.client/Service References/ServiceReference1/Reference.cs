﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTamagotchis", ReplyAction="http://tempuri.org/IService1/GetTamagotchisResponse")]
        WCF_Tamagotchi.service.Tamagotchi[] GetTamagotchis();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTamagotchis", ReplyAction="http://tempuri.org/IService1/GetTamagotchisResponse")]
        System.Threading.Tasks.Task<WCF_Tamagotchi.service.Tamagotchi[]> GetTamagotchisAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDummies", ReplyAction="http://tempuri.org/IService1/GetDummiesResponse")]
        WCF_Tamagotchi.service.Dummy[] GetDummies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDummies", ReplyAction="http://tempuri.org/IService1/GetDummiesResponse")]
        System.Threading.Tasks.Task<WCF_Tamagotchi.service.Dummy[]> GetDummiesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client.client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client.client.ServiceReference1.IService1>, Client.client.ServiceReference1.IService1 {
        
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
        
        public WCF_Tamagotchi.service.Tamagotchi[] GetTamagotchis() {
            return base.Channel.GetTamagotchis();
        }
        
        public System.Threading.Tasks.Task<WCF_Tamagotchi.service.Tamagotchi[]> GetTamagotchisAsync() {
            return base.Channel.GetTamagotchisAsync();
        }
        
        public WCF_Tamagotchi.service.Dummy[] GetDummies() {
            return base.Channel.GetDummies();
        }
        
        public System.Threading.Tasks.Task<WCF_Tamagotchi.service.Dummy[]> GetDummiesAsync() {
            return base.Channel.GetDummiesAsync();
        }
    }
}
