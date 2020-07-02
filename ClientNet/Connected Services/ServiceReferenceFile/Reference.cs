﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientNet.ServiceReferenceFile {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceFile.IFileService")]
    public interface IFileService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/SendFile", ReplyAction="http://tempuri.org/IFileService/SendFileResponse")]
        void SendFile(WCFService.models.InitialFile initialFile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/SendFile", ReplyAction="http://tempuri.org/IFileService/SendFileResponse")]
        System.Threading.Tasks.Task SendFileAsync(WCFService.models.InitialFile initialFile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/Test", ReplyAction="http://tempuri.org/IFileService/TestResponse")]
        void Test(WCFService.models.ReceiveFile name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/Test", ReplyAction="http://tempuri.org/IFileService/TestResponse")]
        System.Threading.Tasks.Task TestAsync(WCFService.models.ReceiveFile name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFileServiceChannel : ClientNet.ServiceReferenceFile.IFileService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FileServiceClient : System.ServiceModel.ClientBase<ClientNet.ServiceReferenceFile.IFileService>, ClientNet.ServiceReferenceFile.IFileService {
        
        public FileServiceClient() {
        }
        
        public FileServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FileServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SendFile(WCFService.models.InitialFile initialFile) {
            base.Channel.SendFile(initialFile);
        }
        
        public System.Threading.Tasks.Task SendFileAsync(WCFService.models.InitialFile initialFile) {
            return base.Channel.SendFileAsync(initialFile);
        }
        
        public void Test(WCFService.models.ReceiveFile name) {
            base.Channel.Test(name);
        }
        
        public System.Threading.Tasks.Task TestAsync(WCFService.models.ReceiveFile name) {
            return base.Channel.TestAsync(name);
        }
    }
}
