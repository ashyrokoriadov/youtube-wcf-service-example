//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorService.Client.LoggingCalculatorServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CalculatorRequest", Namespace="http://schemas.datacontract.org/2004/07/CalculatorService.Model")]
    [System.SerializableAttribute()]
    public partial class CalculatorRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ValueAField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueANameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ValueBField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueBNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ValueA {
            get {
                return this.ValueAField;
            }
            set {
                if ((this.ValueAField.Equals(value) != true)) {
                    this.ValueAField = value;
                    this.RaisePropertyChanged("ValueA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ValueAName {
            get {
                return this.ValueANameField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueANameField, value) != true)) {
                    this.ValueANameField = value;
                    this.RaisePropertyChanged("ValueAName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ValueB {
            get {
                return this.ValueBField;
            }
            set {
                if ((this.ValueBField.Equals(value) != true)) {
                    this.ValueBField = value;
                    this.RaisePropertyChanged("ValueB");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ValueBName {
            get {
                return this.ValueBNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueBNameField, value) != true)) {
                    this.ValueBNameField = value;
                    this.RaisePropertyChanged("ValueBName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CalculatorResponse", Namespace="http://schemas.datacontract.org/2004/07/CalculatorService.Model")]
    [System.SerializableAttribute()]
    public partial class CalculatorResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextExpressionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TextExpression {
            get {
                return this.TextExpressionField;
            }
            set {
                if ((object.ReferenceEquals(this.TextExpressionField, value) != true)) {
                    this.TextExpressionField = value;
                    this.RaisePropertyChanged("TextExpression");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Value {
            get {
                return this.ValueField;
            }
            set {
                if ((this.ValueField.Equals(value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoggingCalculatorServiceReference.ILoggingCalculator")]
    public interface ILoggingCalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoggingCalculator/Add", ReplyAction="http://tempuri.org/ILoggingCalculator/AddResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CalculatorService.Client.LoggingCalculatorServiceReference.CalculatorRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CalculatorService.Client.LoggingCalculatorServiceReference.CalculatorResponse))]
        object Add(object request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoggingCalculator/Add", ReplyAction="http://tempuri.org/ILoggingCalculator/AddResponse")]
        System.Threading.Tasks.Task<object> AddAsync(object request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoggingCalculator/Subtract", ReplyAction="http://tempuri.org/ILoggingCalculator/SubtractResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CalculatorService.Client.LoggingCalculatorServiceReference.CalculatorRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CalculatorService.Client.LoggingCalculatorServiceReference.CalculatorResponse))]
        object Subtract(object request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoggingCalculator/Subtract", ReplyAction="http://tempuri.org/ILoggingCalculator/SubtractResponse")]
        System.Threading.Tasks.Task<object> SubtractAsync(object request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoggingCalculatorChannel : CalculatorService.Client.LoggingCalculatorServiceReference.ILoggingCalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoggingCalculatorClient : System.ServiceModel.ClientBase<CalculatorService.Client.LoggingCalculatorServiceReference.ILoggingCalculator>, CalculatorService.Client.LoggingCalculatorServiceReference.ILoggingCalculator {
        
        public LoggingCalculatorClient() {
        }
        
        public LoggingCalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoggingCalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoggingCalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoggingCalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public object Add(object request) {
            return base.Channel.Add(request);
        }
        
        public System.Threading.Tasks.Task<object> AddAsync(object request) {
            return base.Channel.AddAsync(request);
        }
        
        public object Subtract(object request) {
            return base.Channel.Subtract(request);
        }
        
        public System.Threading.Tasks.Task<object> SubtractAsync(object request) {
            return base.Channel.SubtractAsync(request);
        }
    }
}
