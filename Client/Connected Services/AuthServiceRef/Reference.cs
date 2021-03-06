﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.AuthServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuthServiceRef.IAuth")]
    public interface IAuth {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuth/Auth", ReplyAction="http://tempuri.org/IAuth/AuthResponse")]
        BasicLib.AuthErrors Auth(BasicLib.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuth/Auth", ReplyAction="http://tempuri.org/IAuth/AuthResponse")]
        System.Threading.Tasks.Task<BasicLib.AuthErrors> AuthAsync(BasicLib.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuth/Initialize", ReplyAction="http://tempuri.org/IAuth/InitializeResponse")]
        BasicLib.User Initialize(BasicLib.User incomingUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuth/Initialize", ReplyAction="http://tempuri.org/IAuth/InitializeResponse")]
        System.Threading.Tasks.Task<BasicLib.User> InitializeAsync(BasicLib.User incomingUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuth/RegisterUser", ReplyAction="http://tempuri.org/IAuth/RegisterUserResponse")]
        BasicLib.RegisterResult RegisterUser(BasicLib.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuth/RegisterUser", ReplyAction="http://tempuri.org/IAuth/RegisterUserResponse")]
        System.Threading.Tasks.Task<BasicLib.RegisterResult> RegisterUserAsync(BasicLib.User user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthChannel : Client.AuthServiceRef.IAuth, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthClient : System.ServiceModel.ClientBase<Client.AuthServiceRef.IAuth>, Client.AuthServiceRef.IAuth {
        
        public AuthClient() {
        }
        
        public AuthClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BasicLib.AuthErrors Auth(BasicLib.User user) {
            return base.Channel.Auth(user);
        }
        
        public System.Threading.Tasks.Task<BasicLib.AuthErrors> AuthAsync(BasicLib.User user) {
            return base.Channel.AuthAsync(user);
        }
        
        public BasicLib.User Initialize(BasicLib.User incomingUser) {
            return base.Channel.Initialize(incomingUser);
        }
        
        public System.Threading.Tasks.Task<BasicLib.User> InitializeAsync(BasicLib.User incomingUser) {
            return base.Channel.InitializeAsync(incomingUser);
        }
        
        public BasicLib.RegisterResult RegisterUser(BasicLib.User user) {
            return base.Channel.RegisterUser(user);
        }
        
        public System.Threading.Tasks.Task<BasicLib.RegisterResult> RegisterUserAsync(BasicLib.User user) {
            return base.Channel.RegisterUserAsync(user);
        }
    }
}
