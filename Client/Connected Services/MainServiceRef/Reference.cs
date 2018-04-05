﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.MainServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MainServiceRef.IMain")]
    public interface IMain {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMain/getHouse", ReplyAction="http://tempuri.org/IMain/getHouseResponse")]
        BasicLib.House getHouse(BasicLib.User incomingUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMain/getHouse", ReplyAction="http://tempuri.org/IMain/getHouseResponse")]
        System.Threading.Tasks.Task<BasicLib.House> getHouseAsync(BasicLib.User incomingUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMain/getLogs", ReplyAction="http://tempuri.org/IMain/getLogsResponse")]
        void getLogs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMain/getLogs", ReplyAction="http://tempuri.org/IMain/getLogsResponse")]
        System.Threading.Tasks.Task getLogsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMain/InsertNewCharacter", ReplyAction="http://tempuri.org/IMain/InsertNewCharacterResponse")]
        void InsertNewCharacter(BasicLib.User curUser, BasicLib.House incHs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMain/InsertNewCharacter", ReplyAction="http://tempuri.org/IMain/InsertNewCharacterResponse")]
        System.Threading.Tasks.Task InsertNewCharacterAsync(BasicLib.User curUser, BasicLib.House incHs);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMainChannel : Client.MainServiceRef.IMain, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MainClient : System.ServiceModel.ClientBase<Client.MainServiceRef.IMain>, Client.MainServiceRef.IMain {
        
        public MainClient() {
        }
        
        public MainClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MainClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MainClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MainClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BasicLib.House getHouse(BasicLib.User incomingUser) {
            return base.Channel.getHouse(incomingUser);
        }
        
        public System.Threading.Tasks.Task<BasicLib.House> getHouseAsync(BasicLib.User incomingUser) {
            return base.Channel.getHouseAsync(incomingUser);
        }
        
        public void getLogs() {
            base.Channel.getLogs();
        }
        
        public System.Threading.Tasks.Task getLogsAsync() {
            return base.Channel.getLogsAsync();
        }
        
        public void InsertNewCharacter(BasicLib.User curUser, BasicLib.House incHs) {
            base.Channel.InsertNewCharacter(curUser, incHs);
        }
        
        public System.Threading.Tasks.Task InsertNewCharacterAsync(BasicLib.User curUser, BasicLib.House incHs) {
            return base.Channel.InsertNewCharacterAsync(curUser, incHs);
        }
    }
}
