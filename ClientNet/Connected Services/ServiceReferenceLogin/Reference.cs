﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientNet.ServiceReferenceLogin {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceLogin.ILoginService")]
    public interface ILoginService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/Authentification", ReplyAction="http://tempuri.org/ILoginService/AuthentificationResponse")]
        WCFService.models.ClientResult Authentification(WCFService.models.Client Client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/Authentification", ReplyAction="http://tempuri.org/ILoginService/AuthentificationResponse")]
        System.Threading.Tasks.Task<WCFService.models.ClientResult> AuthentificationAsync(WCFService.models.Client Client);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoginServiceChannel : ClientNet.ServiceReferenceLogin.ILoginService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginServiceClient : System.ServiceModel.ClientBase<ClientNet.ServiceReferenceLogin.ILoginService>, ClientNet.ServiceReferenceLogin.ILoginService {
        
        public LoginServiceClient() {
        }
        
        public LoginServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoginServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFService.models.ClientResult Authentification(WCFService.models.Client Client) {
            return base.Channel.Authentification(Client);
        }
        
        public System.Threading.Tasks.Task<WCFService.models.ClientResult> AuthentificationAsync(WCFService.models.Client Client) {
            return base.Channel.AuthentificationAsync(Client);
        }
    }
}
