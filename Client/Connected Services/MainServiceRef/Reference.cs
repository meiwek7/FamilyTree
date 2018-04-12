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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMain/GetAllCountries", ReplyAction="http://tempuri.org/IMain/GetAllCountriesResponse")]
        string[] GetAllCountries();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMain/GetAllCountries", ReplyAction="http://tempuri.org/IMain/GetAllCountriesResponse")]
        System.Threading.Tasks.Task<string[]> GetAllCountriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMain/GetAllReligious", ReplyAction="http://tempuri.org/IMain/GetAllReligiousResponse")]
        string[] GetAllReligious();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMain/GetAllReligious", ReplyAction="http://tempuri.org/IMain/GetAllReligiousResponse")]
        System.Threading.Tasks.Task<string[]> GetAllReligiousAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMain/GetAllPlaces", ReplyAction="http://tempuri.org/IMain/GetAllPlacesResponse")]
        string[] GetAllPlaces();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMain/GetAllPlaces", ReplyAction="http://tempuri.org/IMain/GetAllPlacesResponse")]
        System.Threading.Tasks.Task<string[]> GetAllPlacesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMain/GetAllNationality", ReplyAction="http://tempuri.org/IMain/GetAllNationalityResponse")]
        string[] GetAllNationality();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMain/GetAllNationality", ReplyAction="http://tempuri.org/IMain/GetAllNationalityResponse")]
        System.Threading.Tasks.Task<string[]> GetAllNationalityAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMain/ChangeChar", ReplyAction="http://tempuri.org/IMain/ChangeCharResponse")]
        void ChangeChar(BasicLib.User incUser, BasicLib.Character incCharacter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMain/ChangeChar", ReplyAction="http://tempuri.org/IMain/ChangeCharResponse")]
        System.Threading.Tasks.Task ChangeCharAsync(BasicLib.User incUser, BasicLib.Character incCharacter);
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
        
        public string[] GetAllCountries() {
            return base.Channel.GetAllCountries();
        }
        
        public System.Threading.Tasks.Task<string[]> GetAllCountriesAsync() {
            return base.Channel.GetAllCountriesAsync();
        }
        
        public string[] GetAllReligious() {
            return base.Channel.GetAllReligious();
        }
        
        public System.Threading.Tasks.Task<string[]> GetAllReligiousAsync() {
            return base.Channel.GetAllReligiousAsync();
        }
        
        public string[] GetAllPlaces() {
            return base.Channel.GetAllPlaces();
        }
        
        public System.Threading.Tasks.Task<string[]> GetAllPlacesAsync() {
            return base.Channel.GetAllPlacesAsync();
        }
        
        public string[] GetAllNationality() {
            return base.Channel.GetAllNationality();
        }
        
        public System.Threading.Tasks.Task<string[]> GetAllNationalityAsync() {
            return base.Channel.GetAllNationalityAsync();
        }
        
        public void ChangeChar(BasicLib.User incUser, BasicLib.Character incCharacter) {
            base.Channel.ChangeChar(incUser, incCharacter);
        }
        
        public System.Threading.Tasks.Task ChangeCharAsync(BasicLib.User incUser, BasicLib.Character incCharacter) {
            return base.Channel.ChangeCharAsync(incUser, incCharacter);
        }
    }
}
