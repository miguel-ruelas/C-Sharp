﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumeBookFinderService.localhost {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="localhost.IBookFinderService")]
    public interface IBookFinderService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookFinderService/GetBookList", ReplyAction="http://tempuri.org/IBookFinderService/GetBookListResponse")]
        string[] GetBookList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookFinderService/GetBookList", ReplyAction="http://tempuri.org/IBookFinderService/GetBookListResponse")]
        System.Threading.Tasks.Task<string[]> GetBookListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookFinderService/FindBook", ReplyAction="http://tempuri.org/IBookFinderService/FindBookResponse")]
        string FindBook(string partialName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookFinderService/FindBook", ReplyAction="http://tempuri.org/IBookFinderService/FindBookResponse")]
        System.Threading.Tasks.Task<string> FindBookAsync(string partialName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookFinderServiceChannel : ConsumeBookFinderService.localhost.IBookFinderService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookFinderServiceClient : System.ServiceModel.ClientBase<ConsumeBookFinderService.localhost.IBookFinderService>, ConsumeBookFinderService.localhost.IBookFinderService {
        
        public BookFinderServiceClient() {
        }
        
        public BookFinderServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookFinderServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookFinderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookFinderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetBookList() {
            return base.Channel.GetBookList();
        }
        
        public System.Threading.Tasks.Task<string[]> GetBookListAsync() {
            return base.Channel.GetBookListAsync();
        }
        
        public string FindBook(string partialName) {
            return base.Channel.FindBook(partialName);
        }
        
        public System.Threading.Tasks.Task<string> FindBookAsync(string partialName) {
            return base.Channel.FindBookAsync(partialName);
        }
    }
}
