﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XML.Company.ConnectedServices.BankServiceReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PaymentActionRequest", Namespace="http://schemas.datacontract.org/2004/07/XML.CentralBank.Model")]
    public partial class PaymentActionRequest : object
    {
        
        private decimal AmmountField;
        
        private string PayerField;
        
        private string PurposeOfPaymentField;
        
        private string RecipientField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Ammount
        {
            get
            {
                return this.AmmountField;
            }
            set
            {
                this.AmmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Payer
        {
            get
            {
                return this.PayerField;
            }
            set
            {
                this.PayerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PurposeOfPayment
        {
            get
            {
                return this.PurposeOfPaymentField;
            }
            set
            {
                this.PurposeOfPaymentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Recipient
        {
            get
            {
                return this.RecipientField;
            }
            set
            {
                this.RecipientField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AccountStatementRequest", Namespace="http://schemas.datacontract.org/2004/07/XML.CentralBank.Model")]
    public partial class AccountStatementRequest : object
    {
        
        private string AccountNumberField;
        
        private System.DateTime DateField;
        
        private int OverviewNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AccountNumber
        {
            get
            {
                return this.AccountNumberField;
            }
            set
            {
                this.AccountNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OverviewNumber
        {
            get
            {
                return this.OverviewNumberField;
            }
            set
            {
                this.OverviewNumberField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AccountStatementResponse", Namespace="http://schemas.datacontract.org/2004/07/XML.CentralBank.Model")]
    public partial class AccountStatementResponse : object
    {
        
        private string NumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Number
        {
            get
            {
                return this.NumberField;
            }
            set
            {
                this.NumberField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BankServiceReference.IBankService")]
    public interface IBankService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankService/PaymentAction", ReplyAction="http://tempuri.org/IBankService/PaymentActionResponse")]
        System.Threading.Tasks.Task<BankServiceReference.PaymentActionResponse> PaymentActionAsync(BankServiceReference.PaymentActionRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankService/GetAccountStatement", ReplyAction="http://tempuri.org/IBankService/GetAccountStatementResponse")]
        System.Threading.Tasks.Task<BankServiceReference.GetAccountStatementResponse> GetAccountStatementAsync(BankServiceReference.GetAccountStatementRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PaymentAction", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class PaymentActionRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public BankServiceReference.PaymentActionRequest request;
        
        public PaymentActionRequest1()
        {
        }
        
        public PaymentActionRequest1(BankServiceReference.PaymentActionRequest request)
        {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PaymentActionResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class PaymentActionResponse
    {
        
        public PaymentActionResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAccountStatement", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAccountStatementRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public BankServiceReference.AccountStatementRequest request;
        
        public GetAccountStatementRequest()
        {
        }
        
        public GetAccountStatementRequest(BankServiceReference.AccountStatementRequest request)
        {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAccountStatementResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAccountStatementResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public BankServiceReference.AccountStatementResponse GetAccountStatementResult;
        
        public GetAccountStatementResponse()
        {
        }
        
        public GetAccountStatementResponse(BankServiceReference.AccountStatementResponse GetAccountStatementResult)
        {
            this.GetAccountStatementResult = GetAccountStatementResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    public interface IBankServiceChannel : BankServiceReference.IBankService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    public partial class BankServiceClient : System.ServiceModel.ClientBase<BankServiceReference.IBankService>, BankServiceReference.IBankService
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public BankServiceClient() : 
                base(BankServiceClient.GetDefaultBinding(), BankServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IBankService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BankServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(BankServiceClient.GetBindingForEndpoint(endpointConfiguration), BankServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BankServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(BankServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BankServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(BankServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BankServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<BankServiceReference.PaymentActionResponse> PaymentActionAsync(BankServiceReference.PaymentActionRequest1 request)
        {
            return base.Channel.PaymentActionAsync(request);
        }
        
        public System.Threading.Tasks.Task<BankServiceReference.GetAccountStatementResponse> GetAccountStatementAsync(BankServiceReference.GetAccountStatementRequest request)
        {
            return base.Channel.GetAccountStatementAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IBankService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IBankService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:4475/BankService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return BankServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IBankService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return BankServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IBankService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IBankService,
        }
    }
}
