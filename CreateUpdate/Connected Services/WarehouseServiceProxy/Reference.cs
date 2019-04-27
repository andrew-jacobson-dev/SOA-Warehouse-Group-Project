﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CreateUpdateClient.WarehouseServiceProxy {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Warehouse", Namespace="http://schemas.datacontract.org/2004/07/Warehouse_Prj.Service")]
    [System.SerializableAttribute()]
    public partial class Warehouse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WarehouseAddressCityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WarehouseAddressStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WarehouseAddressStreetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WarehouseAddressZipcodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WarehouseIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WarehouseNameField;
        
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
        public string WarehouseAddressCity {
            get {
                return this.WarehouseAddressCityField;
            }
            set {
                if ((object.ReferenceEquals(this.WarehouseAddressCityField, value) != true)) {
                    this.WarehouseAddressCityField = value;
                    this.RaisePropertyChanged("WarehouseAddressCity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WarehouseAddressState {
            get {
                return this.WarehouseAddressStateField;
            }
            set {
                if ((object.ReferenceEquals(this.WarehouseAddressStateField, value) != true)) {
                    this.WarehouseAddressStateField = value;
                    this.RaisePropertyChanged("WarehouseAddressState");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WarehouseAddressStreet {
            get {
                return this.WarehouseAddressStreetField;
            }
            set {
                if ((object.ReferenceEquals(this.WarehouseAddressStreetField, value) != true)) {
                    this.WarehouseAddressStreetField = value;
                    this.RaisePropertyChanged("WarehouseAddressStreet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WarehouseAddressZipcode {
            get {
                return this.WarehouseAddressZipcodeField;
            }
            set {
                if ((object.ReferenceEquals(this.WarehouseAddressZipcodeField, value) != true)) {
                    this.WarehouseAddressZipcodeField = value;
                    this.RaisePropertyChanged("WarehouseAddressZipcode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WarehouseID {
            get {
                return this.WarehouseIDField;
            }
            set {
                if ((this.WarehouseIDField.Equals(value) != true)) {
                    this.WarehouseIDField = value;
                    this.RaisePropertyChanged("WarehouseID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WarehouseName {
            get {
                return this.WarehouseNameField;
            }
            set {
                if ((object.ReferenceEquals(this.WarehouseNameField, value) != true)) {
                    this.WarehouseNameField = value;
                    this.RaisePropertyChanged("WarehouseName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WarehouseServiceProxy.IWarehouse")]
    public interface IWarehouse {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouse/GetWarehouse", ReplyAction="http://tempuri.org/IWarehouse/GetWarehouseResponse")]
        CreateUpdateClient.WarehouseServiceProxy.Warehouse GetWarehouse(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouse/GetWarehouse", ReplyAction="http://tempuri.org/IWarehouse/GetWarehouseResponse")]
        System.Threading.Tasks.Task<CreateUpdateClient.WarehouseServiceProxy.Warehouse> GetWarehouseAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouse/GetAllWarehouses", ReplyAction="http://tempuri.org/IWarehouse/GetAllWarehousesResponse")]
        CreateUpdateClient.WarehouseServiceProxy.Warehouse[] GetAllWarehouses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouse/GetAllWarehouses", ReplyAction="http://tempuri.org/IWarehouse/GetAllWarehousesResponse")]
        System.Threading.Tasks.Task<CreateUpdateClient.WarehouseServiceProxy.Warehouse[]> GetAllWarehousesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouse/UpdateWarehouse", ReplyAction="http://tempuri.org/IWarehouse/UpdateWarehouseResponse")]
        CreateUpdateClient.WarehouseServiceProxy.UpdateWarehouseResponse UpdateWarehouse(CreateUpdateClient.WarehouseServiceProxy.UpdateWarehouseRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouse/UpdateWarehouse", ReplyAction="http://tempuri.org/IWarehouse/UpdateWarehouseResponse")]
        System.Threading.Tasks.Task<CreateUpdateClient.WarehouseServiceProxy.UpdateWarehouseResponse> UpdateWarehouseAsync(CreateUpdateClient.WarehouseServiceProxy.UpdateWarehouseRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateWarehouse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateWarehouseRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public CreateUpdateClient.WarehouseServiceProxy.Warehouse warehouse;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public UpdateWarehouseRequest() {
        }
        
        public UpdateWarehouseRequest(CreateUpdateClient.WarehouseServiceProxy.Warehouse warehouse, string message) {
            this.warehouse = warehouse;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateWarehouseResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateWarehouseResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool UpdateWarehouseResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public UpdateWarehouseResponse() {
        }
        
        public UpdateWarehouseResponse(bool UpdateWarehouseResult, string message) {
            this.UpdateWarehouseResult = UpdateWarehouseResult;
            this.message = message;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWarehouseChannel : CreateUpdateClient.WarehouseServiceProxy.IWarehouse, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WarehouseClient : System.ServiceModel.ClientBase<CreateUpdateClient.WarehouseServiceProxy.IWarehouse>, CreateUpdateClient.WarehouseServiceProxy.IWarehouse {
        
        public WarehouseClient() {
        }
        
        public WarehouseClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WarehouseClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WarehouseClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WarehouseClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CreateUpdateClient.WarehouseServiceProxy.Warehouse GetWarehouse(int id) {
            return base.Channel.GetWarehouse(id);
        }
        
        public System.Threading.Tasks.Task<CreateUpdateClient.WarehouseServiceProxy.Warehouse> GetWarehouseAsync(int id) {
            return base.Channel.GetWarehouseAsync(id);
        }
        
        public CreateUpdateClient.WarehouseServiceProxy.Warehouse[] GetAllWarehouses() {
            return base.Channel.GetAllWarehouses();
        }
        
        public System.Threading.Tasks.Task<CreateUpdateClient.WarehouseServiceProxy.Warehouse[]> GetAllWarehousesAsync() {
            return base.Channel.GetAllWarehousesAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CreateUpdateClient.WarehouseServiceProxy.UpdateWarehouseResponse CreateUpdateClient.WarehouseServiceProxy.IWarehouse.UpdateWarehouse(CreateUpdateClient.WarehouseServiceProxy.UpdateWarehouseRequest request) {
            return base.Channel.UpdateWarehouse(request);
        }
        
        public bool UpdateWarehouse(CreateUpdateClient.WarehouseServiceProxy.Warehouse warehouse, ref string message) {
            CreateUpdateClient.WarehouseServiceProxy.UpdateWarehouseRequest inValue = new CreateUpdateClient.WarehouseServiceProxy.UpdateWarehouseRequest();
            inValue.warehouse = warehouse;
            inValue.message = message;
            CreateUpdateClient.WarehouseServiceProxy.UpdateWarehouseResponse retVal = ((CreateUpdateClient.WarehouseServiceProxy.IWarehouse)(this)).UpdateWarehouse(inValue);
            message = retVal.message;
            return retVal.UpdateWarehouseResult;
        }
        
        public System.Threading.Tasks.Task<CreateUpdateClient.WarehouseServiceProxy.UpdateWarehouseResponse> UpdateWarehouseAsync(CreateUpdateClient.WarehouseServiceProxy.UpdateWarehouseRequest request) {
            return base.Channel.UpdateWarehouseAsync(request);
        }
    }
}
