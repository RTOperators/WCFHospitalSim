﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAppA.ServiceReferenceA {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceA.IServiceA")]
    public interface IServiceA {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceA/getPatients", ReplyAction="http://tempuri.org/IServiceA/getPatientsResponse")]
        SharedLibray.Patient[] getPatients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceA/getPatients", ReplyAction="http://tempuri.org/IServiceA/getPatientsResponse")]
        System.Threading.Tasks.Task<SharedLibray.Patient[]> getPatientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceA/getPatientsFromB", ReplyAction="http://tempuri.org/IServiceA/getPatientsFromBResponse")]
        SharedLibray.Patient[] getPatientsFromB();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceA/getPatientsFromB", ReplyAction="http://tempuri.org/IServiceA/getPatientsFromBResponse")]
        System.Threading.Tasks.Task<SharedLibray.Patient[]> getPatientsFromBAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceA/ConnectionOK", ReplyAction="http://tempuri.org/IServiceA/ConnectionOKResponse")]
        bool ConnectionOK();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceA/ConnectionOK", ReplyAction="http://tempuri.org/IServiceA/ConnectionOKResponse")]
        System.Threading.Tasks.Task<bool> ConnectionOKAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceAChannel : ConsoleAppA.ServiceReferenceA.IServiceA, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceAClient : System.ServiceModel.ClientBase<ConsoleAppA.ServiceReferenceA.IServiceA>, ConsoleAppA.ServiceReferenceA.IServiceA {
        
        public ServiceAClient() {
        }
        
        public ServiceAClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceAClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SharedLibray.Patient[] getPatients() {
            return base.Channel.getPatients();
        }
        
        public System.Threading.Tasks.Task<SharedLibray.Patient[]> getPatientsAsync() {
            return base.Channel.getPatientsAsync();
        }
        
        public SharedLibray.Patient[] getPatientsFromB() {
            return base.Channel.getPatientsFromB();
        }
        
        public System.Threading.Tasks.Task<SharedLibray.Patient[]> getPatientsFromBAsync() {
            return base.Channel.getPatientsFromBAsync();
        }
        
        public bool ConnectionOK() {
            return base.Channel.ConnectionOK();
        }
        
        public System.Threading.Tasks.Task<bool> ConnectionOKAsync() {
            return base.Channel.ConnectionOKAsync();
        }
    }
}
