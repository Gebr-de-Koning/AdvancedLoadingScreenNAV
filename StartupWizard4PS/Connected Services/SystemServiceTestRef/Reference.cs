﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StartupWizard4PS.SystemServiceTestRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/nav/system/", ConfigurationName="SystemServiceTestRef.SystemService_Port")]
    public interface SystemService_Port {
        
        // CODEGEN: Generating message contract since the wrapper name (Companies_Result) of message Companies_Result does not match the default value (Companies)
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/nav/system/:Companies", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        StartupWizard4PS.SystemServiceTestRef.Companies_Result Companies(StartupWizard4PS.SystemServiceTestRef.Companies request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/nav/system/:Companies", ReplyAction="*")]
        System.Threading.Tasks.Task<StartupWizard4PS.SystemServiceTestRef.Companies_Result> CompaniesAsync(StartupWizard4PS.SystemServiceTestRef.Companies request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Companies", WrapperNamespace="urn:microsoft-dynamics-schemas/nav/system/", IsWrapped=true)]
    public partial class Companies {
        
        public Companies() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Companies_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/nav/system/", IsWrapped=true)]
    public partial class Companies_Result {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/nav/system/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return_value")]
        public string[] return_value;
        
        public Companies_Result() {
        }
        
        public Companies_Result(string[] return_value) {
            this.return_value = return_value;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SystemService_PortChannel : StartupWizard4PS.SystemServiceTestRef.SystemService_Port, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SystemService_PortClient : System.ServiceModel.ClientBase<StartupWizard4PS.SystemServiceTestRef.SystemService_Port>, StartupWizard4PS.SystemServiceTestRef.SystemService_Port {
        
        public SystemService_PortClient() {
        }
        
        public SystemService_PortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SystemService_PortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SystemService_PortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SystemService_PortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        StartupWizard4PS.SystemServiceTestRef.Companies_Result StartupWizard4PS.SystemServiceTestRef.SystemService_Port.Companies(StartupWizard4PS.SystemServiceTestRef.Companies request) {
            return base.Channel.Companies(request);
        }
        
        public string[] Companies() {
            StartupWizard4PS.SystemServiceTestRef.Companies inValue = new StartupWizard4PS.SystemServiceTestRef.Companies();
            StartupWizard4PS.SystemServiceTestRef.Companies_Result retVal = ((StartupWizard4PS.SystemServiceTestRef.SystemService_Port)(this)).Companies(inValue);
            return retVal.return_value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<StartupWizard4PS.SystemServiceTestRef.Companies_Result> StartupWizard4PS.SystemServiceTestRef.SystemService_Port.CompaniesAsync(StartupWizard4PS.SystemServiceTestRef.Companies request) {
            return base.Channel.CompaniesAsync(request);
        }
        
        public System.Threading.Tasks.Task<StartupWizard4PS.SystemServiceTestRef.Companies_Result> CompaniesAsync() {
            StartupWizard4PS.SystemServiceTestRef.Companies inValue = new StartupWizard4PS.SystemServiceTestRef.Companies();
            return ((StartupWizard4PS.SystemServiceTestRef.SystemService_Port)(this)).CompaniesAsync(inValue);
        }
    }
}